using Sistema_Gestion_de_Stock.Entidades;
using Sistema_Gestion_de_Stock.Repositorios;
using Sistema_Gestion_de_Stock.Utilidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Gestion_de_Stock.Formularios
{
    public partial class FormProductos : Form
    {
        private RepositorioProducto repoProductos;
        private RepositorioRubro repoRubros;
        private RepositorioMovimientos repoMovimientos;
        public FormProductos()
        {
            InitializeComponent();
            repoProductos = new RepositorioProducto();
            repoRubros = new RepositorioRubro();
            repoMovimientos = new RepositorioMovimientos();

            ControlarVencimientos();
            CargarRubros();
            CargarProductos();
        }

        private void CargarRubros()
        {
            var rubros = repoRubros.Listar();

            cmbRubros.DataSource = new List<Rubro>(rubros);
            cmbRubros.DisplayMember = "Categoria";
            cmbRubros.ValueMember = "IdRubro";
            cmbRubros.SelectedIndex = -1;

            cmbFiltrarRubro.DataSource = new List<Rubro>(rubros);
            cmbFiltrarRubro.DisplayMember = "Categoria";
            cmbFiltrarRubro.ValueMember = "IdRubro";
            cmbFiltrarRubro.SelectedIndex = -1;
        }

        private void CargarProductos()
        {
            dgvProductos.Rows.Clear();
            dgvProductos.Columns.Clear();

            dgvProductos.Columns.Add("IdProducto", "ID");
            dgvProductos.Columns.Add("Nombre", "Nombre");
            dgvProductos.Columns.Add("Descripcion", "Descripcion");
            dgvProductos.Columns.Add("PrecioVenta", "Precio Venta");
            dgvProductos.Columns.Add("Stock", "Stock");
            dgvProductos.Columns.Add("Rubro", "Rubro");
            dgvProductos.Columns.Add("Vencimiento", "Vencimiento");
            dgvProductos.Columns.Add("Disponible", "Disponible");
            dgvProductos.Columns[0].Width = 35;
            dgvProductos.Columns[4].Width = 60;


            var productos = repoProductos.Listar().Where(p => p.Disponible).ToList();

            MostrarEnGrid(productos);
        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos()) return;

            var nuevo = new Producto(
                GenerarNuevoId(),
                txtNombre.Text,
                txtDescripcion.Text,
                0,
                ((Rubro)cmbRubros.SelectedItem).IdRubro,
                true
            );

            repoProductos.Agregar(nuevo);

            if (nudCantidad.Value > 0)
            {
                var ingreso = new Ingreso(
                    GenerarNuevoIdMovimiento(),
                    nuevo.IdProducto,
                    DateTime.Now,
                    (int)nudCantidad.Value,
                    0, // sin proveedor
                    chkVencimiento.Checked ? dtpVencimiento.Value : new DateTime(1900, 1, 1),
                    (double)nudPrecio.Value
                );

                ingreso.AplicarMovimiento(nuevo);
                repoMovimientos.Agregar(ingreso);
                repoProductos.Modificar(nuevo);
            }

            CargarProductos();
            LimpiarCampos();

        }

        private void FiltrarProductos()
        {
            string nombre = txtBuscarNombre.Text.ToLower();
            string idTexto = txtBuscarID.Text;
            int.TryParse(idTexto, out int id);

            int? idRubro = (cmbFiltrarRubro.SelectedItem is Rubro rubroSel) ? rubroSel.IdRubro : (int?)null;

            var productos = repoProductos.Listar();

            if (!string.IsNullOrWhiteSpace(nombre))
                productos = productos.Where(p => p.Nombre.ToLower().Contains(nombre)).ToList();

            if (!string.IsNullOrWhiteSpace(idTexto))
                productos = productos.Where(p => p.IdProducto == id).ToList();

            if (idRubro.HasValue)
                productos = productos.Where(p => p.IdRubro == idRubro.Value).ToList();

            if (!chkMostrarBajas.Checked)
                productos = productos.Where(p => p.Disponible).ToList();

            if (chkPorVencer.Checked)
                MostrarPorVencer(productos);
            else
                MostrarEnGrid(productos);
        }

        private void MostrarEnGrid(List<Producto> productos)
        {
            dgvProductos.Rows.Clear();

            foreach (var p in productos)
            {
                var rubro = repoRubros.BuscarPorId(p.IdRubro);
                string nombreRubro = rubro != null ? rubro.Categoria : "Sin Rubro";
                string vencimiento = p.ListaLotes
                    .Where(l => l.FechaVencimiento != new DateTime(1900, 1, 1))
                    .OrderBy(l => l.FechaVencimiento)
                    .Select(l => l.FechaVencimiento.ToString("dd/MM/yyyy"))
                    .FirstOrDefault() ?? "Sin vencimiento";

                int rowIndex = dgvProductos.Rows.Add(p.IdProducto, p.Nombre, p.Descripcion, p.PrecioVenta, p.CalcularStockTotal(), nombreRubro, vencimiento, p.Disponible ? "Sí" : "No");

                if (!p.Disponible)
                    dgvProductos.Rows[rowIndex].DefaultCellStyle.ForeColor = Color.Gray;
            }
            dgvProductos.ClearSelection();
        }

        private void ControlarVencimientos()
        {
            bool huboCambios = false;
            var productos = repoProductos.Listar();
            DateTime hoy = DateTime.Today;

            foreach (var p in productos)
            {
                var lotesVencidos = p.ListaLotes
                    .Where(l => l.FechaVencimiento != new DateTime(1900, 1, 1) && l.FechaVencimiento < hoy)
                    .ToList();

                foreach (var lote in lotesVencidos)
                {
                    // Crear egreso por vencimiento
                    int nuevoIdMov = repoMovimientos.Listar().Any()
                        ? repoMovimientos.Listar().Max(m => m.IdMovimiento) + 1
                        : 1;

                    var egresoVencimiento = new Egreso(
                        nuevoIdMov,
                        p.IdProducto,
                        DateTime.Now,
                        lote.Cantidad,
                        TipoEgreso.Vencimiento
                    );

                    egresoVencimiento.AplicarMovimiento(p);

                    repoMovimientos.Agregar(egresoVencimiento);
                    huboCambios = true;
                }
            }
            if (huboCambios)
                MessageBox.Show("Se procesaron los lotes vencidos y se registraron como egresos.");
        }

        private int GenerarNuevoIdMovimiento()
        {
            var lista = repoMovimientos.Listar();
            return lista.Any() ? lista.Max(x => x.IdMovimiento) + 1 : 1;
        }

        private void btnModificarProducto_Click(object sender, EventArgs e)
        {
            if (dgvProductos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccioná un producto para modificar.");
                return;
            }

            int id = (int)dgvProductos.SelectedRows[0].Cells["IdProducto"].Value;
            var producto = repoProductos.BuscarPorId(id);

            producto.Nombre = txtNombre.Text;
            producto.Descripcion = txtDescripcion.Text;
            producto.IdRubro = ((Rubro)cmbRubros.SelectedItem).IdRubro;

            repoProductos.Modificar(producto);
            CargarProductos();
            LimpiarCampos();
        }

        private void btnEliminarProducto_Click(object sender, EventArgs e)
        {
            if (dgvProductos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecciona un producto para eliminar.");
                return;
            }

            int id = (int)dgvProductos.SelectedRows[0].Cells["IdProducto"].Value;

            var confirm = MessageBox.Show("¿Seguro que quieres eliminar este producto?", "Confirmar", MessageBoxButtons.YesNo);
            if (confirm == DialogResult.Yes)
            {
                repoProductos.Eliminar(id);
                CargarProductos();
                LimpiarCampos();
            }
        }

        private void btnLimpiarProductos_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void btnCopiarProducto_Click(object sender, EventArgs e)
        {
            int id = (int)dgvProductos.SelectedRows[0].Cells["IdProducto"].Value;
            var producto = repoProductos.BuscarPorId(id);

            txtNombre.Text = producto.Nombre;
            txtDescripcion.Text = producto.Descripcion;
            nudCantidad.Value = producto.CalcularStockTotal();
            nudPrecio.Value = (decimal)producto.PrecioVenta;
            chkVencimiento.Checked = false;
            dtpVencimiento.Value = DateTime.Today;

            var rubro = repoRubros.BuscarPorId(producto.IdRubro);
            if (rubro != null)
                cmbRubros.SelectedItem = rubro;
        }

        private int GenerarNuevoId()
        {
            var lista = repoProductos.Listar();
            return lista.Any() ? lista.Max(x => x.IdProducto) + 1 : 1;
        }

        private void LimpiarCampos()
        {
            txtNombre.Clear();
            txtDescripcion.Clear();
            nudPrecio.Value = 0;
            nudCantidad.Value = 0;
            cmbRubros.SelectedIndex = -1;
            chkVencimiento.Checked = false;
            dgvProductos.ClearSelection();
        }

        private bool ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("Faltan completar campos obligatorios.");
                return false;
            }

            if (!(cmbRubros.SelectedItem is Rubro rubroSeleccionado))
            {
                MessageBox.Show("Seleccioná un rubro válido.");
                return false;
            }

            if (nudCantidad.Value < 0)
            {
                MessageBox.Show("La cantidad no puede ser negativa.");
                return false;
            }

            if (nudPrecio.Value <= 0)
            {
                MessageBox.Show("El precio debe ser mayor a cero.");
                return false;
            }

            bool nombreYaExiste = repoProductos.Listar()
                .Any(p => p.Nombre.Equals(txtNombre.Text, StringComparison.OrdinalIgnoreCase) && p.Disponible);

            if (nombreYaExiste && btnAgregarProducto.Enabled)
            {
                MessageBox.Show("Ya existe un producto con ese nombre.");
                return false;
            }

            return true;
        }

        private void dgvProductos_SelectionChanged(object sender, EventArgs e)
        {
            bool haySeleccion = dgvProductos.SelectedRows.Count > 0;

            btnModificarProducto.Enabled = haySeleccion;
            btnEliminarProducto.Enabled = haySeleccion;
            btnCopiarProducto.Enabled = haySeleccion;
        }

        private void chkVencimiento_CheckedChanged(object sender, EventArgs e)
        {
            dtpVencimiento.Enabled = chkVencimiento.Checked;
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            FiltrarProductos();
        }

        private void btnLimpiarFiltros_Click(object sender, EventArgs e)
        {
            txtBuscarNombre.Clear();
            txtBuscarID.Clear();
            cmbFiltrarRubro.SelectedIndex = -1;
            chkMostrarBajas.Checked = false;
            chkPorVencer.Checked = false;
            FiltrarProductos();
        }

        private void MostrarPorVencer(List<Producto> productos)
        {
            DateTime hoy = DateTime.Today;
            DateTime limite = hoy.AddDays(7);

            dgvProductos.Rows.Clear();

            foreach (var p in productos)
            {
                var lotesPorVencer = p.LotesPorVencer();

                if (lotesPorVencer.Any())
                {
                    int cantidadPorVencer = lotesPorVencer.Sum(l => l.Cantidad);

                    var rubro = repoRubros.BuscarPorId(p.IdRubro);
                    string nombreRubro = rubro != null ? rubro.Categoria : "Sin Rubro";
                    string vencimiento = p.ListaLotes
                        .Where(l => l.FechaVencimiento != new DateTime(1900, 1, 1))
                        .OrderBy(l => l.FechaVencimiento)
                        .Select(l => l.FechaVencimiento.ToString("dd/MM/yyyy"))
                        .FirstOrDefault() ?? "Sin vencimiento";

                    int rowIndex = dgvProductos.Rows.Add(p.IdProducto, p.Nombre, p.Descripcion, p.PrecioVenta, cantidadPorVencer, nombreRubro, vencimiento, p.Disponible ? "Sí" : "No");

                    if (!p.Disponible)
                        dgvProductos.Rows[rowIndex].DefaultCellStyle.ForeColor = Color.Gray;
                }
            }
        }

    }
}
