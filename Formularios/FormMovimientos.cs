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
    public partial class FormMovimientos : Form
    {
        private RepositorioProducto repoProductos;
        private RepositorioProveedor repoProveedores;
        private RepositorioMovimientos repoMovimientos;

        public FormMovimientos()
        {
            InitializeComponent();
            repoProductos = new RepositorioProducto();
            repoProveedores = new RepositorioProveedor();
            repoMovimientos = new RepositorioMovimientos();

            repoMovimientos.CargarDesdeArchivo();

            CargarCombos();
            ConfigurarControles();
            ConfigurarGridMovimientos();
            ActualizarGridMovimientos();
        }

        private void CargarCombos()
        {
            var disponibles = repoProductos.Listar().Where(p => p.Disponible).OrderBy(p => p.Nombre).ToList();

            cmbProductosIngreso.DataSource = new List<Producto>(disponibles);
            cmbProductosIngreso.DisplayMember = "Nombre";
            cmbProductosIngreso.ValueMember = "IdProducto";

            cmbProveedor.DataSource = repoProveedores.Listar();
            cmbProveedor.DisplayMember = "Nombre";
            cmbProveedor.ValueMember = "IdProveedor";

            cmbProductosEgreso.DataSource = new List<Producto>(disponibles);
            cmbProductosEgreso.DisplayMember = "Nombre";
            cmbProductosEgreso.ValueMember = "IdProducto";

            cmbTipoEgreso.DataSource = Enum.GetValues(typeof(TipoEgreso));

            cmbFiltroProducto.DataSource = new List<Producto>(disponibles);
            cmbFiltroProducto.DisplayMember = "Nombre";
            cmbFiltroProducto.ValueMember = "IdProducto";
            cmbFiltroProducto.SelectedIndex = -1;

            cmbFiltroTipo.Items.Clear();
            cmbFiltroTipo.Items.AddRange(new string[] { "Todos", "Ingreso", "Egreso" });
            cmbFiltroTipo.SelectedIndex = 0;
        }

        private void ConfigurarControles()
        {
            dtpVencimiento.Enabled = chkVencimiento.Checked;
            chkVencimiento.CheckedChanged += (s, e) =>
            {
                dtpVencimiento.Enabled = chkVencimiento.Checked;
            };

            dtpDesde.Value = DateTime.Today.AddMonths(-1);
            dtpHasta.Value = DateTime.Today;
        }

        private void ConfigurarGridMovimientos()
        {
            dgvMovimientos.Rows.Clear();
            dgvMovimientos.Columns.Clear();

            dgvMovimientos.Columns.Add("Id", "ID");
            dgvMovimientos.Columns.Add("Producto", "Producto");
            dgvMovimientos.Columns.Add("Fecha", "Fecha");
            dgvMovimientos.Columns.Add("Tipo", "Tipo");
            dgvMovimientos.Columns.Add("Cantidad", "Cantidad");
            dgvMovimientos.Columns.Add("Precio", "Precio");
        }

        private void btnRegistrarIngreso_Click(object sender, EventArgs e)
        {
            if (cmbProductosIngreso.SelectedItem == null)
            {
                MessageBox.Show("Seleccioná un producto.");
                return;
            }

            if (cmbProveedor.SelectedItem == null)
            {
                MessageBox.Show("Seleccioná un proveedor.");
                return;
            }

            if (nudCantidadIngreso.Value <= 0 || nudPrecio.Value <= 0)
            {
                MessageBox.Show("La cantidad y el precio deben ser mayores a 0.");
                return;
            }

            var producto = (Producto)cmbProductosIngreso.SelectedItem;
            var proveedor = (Proveedor)cmbProveedor.SelectedItem;

            int cantidad = (int)nudCantidadIngreso.Value;
            double precio = (double)nudPrecio.Value;
            DateTime vencimiento = chkVencimiento.Checked ? dtpVencimiento.Value : new DateTime(1900, 1, 1);

            int nuevoId = GenerarNuevoIdMovimiento();

            var ingreso = new Ingreso(nuevoId, producto.IdProducto, DateTime.Now, cantidad, proveedor.IdProveedor, vencimiento, precio);
            ingreso.AplicarMovimiento(producto);

            repoMovimientos.Agregar(ingreso);
            repoProductos.Modificar(producto);

            MessageBox.Show("Ingreso registrado correctamente.");
            LimpiarIngreso();
            ActualizarGridMovimientos();
            RecargarCombosProductos();
        }

        private void btnRegistrarEgreso_Click(object sender, EventArgs e)
        {
            if (cmbProductosEgreso.SelectedItem == null)
            {
                MessageBox.Show("Seleccioná un producto.");
                return;
            }

            var producto = (Producto)cmbProductosEgreso.SelectedItem;

            int cantidad = (int)nudCantidadEgreso.Value;
            if (cantidad <= 0)
            {
                MessageBox.Show("La cantidad debe ser mayor a 0.");
                return;
            }

            if (cantidad > producto.CalcularStockTotal())
            {
                MessageBox.Show("No hay stock suficiente para el egreso.");
                return;
            }

            if (cmbTipoEgreso.SelectedItem == null)
            {
                MessageBox.Show("Seleccioná un tipo de egreso.");
                return;
            }

            TipoEgreso tipo = (TipoEgreso)cmbTipoEgreso.SelectedItem;
            int nuevoId = GenerarNuevoIdMovimiento();

            var egreso = new Egreso(nuevoId, producto.IdProducto, DateTime.Now, cantidad, tipo);
            egreso.AplicarMovimiento(producto);

            repoMovimientos.Agregar(egreso);
            repoProductos.Modificar(producto);

            MessageBox.Show("Egreso registrado correctamente.");
            LimpiarEgreso();
            ActualizarGridMovimientos();
            RecargarCombosProductos();
        }

        private int GenerarNuevoIdMovimiento()
        {
            var lista = repoMovimientos.Listar();
            return lista.Any() ? lista.Max(x => x.IdMovimiento) + 1 : 1;
        }

        private void LimpiarIngreso()
        {
            nudCantidadIngreso.Value = 0;
            nudPrecio.Value = 0;
            chkVencimiento.Checked = false;
            dtpVencimiento.Value = DateTime.Today;
        }

        private void LimpiarEgreso()
        {
            nudCantidadEgreso.Value = 0;
            cmbTipoEgreso.SelectedIndex = 0;
        }

        private void ActualizarGridMovimientos()
        {
            dgvMovimientos.Rows.Clear();

            foreach (var m in repoMovimientos.Listar())
            {
                var producto = repoProductos.BuscarPorId(m.IdProducto);
                string nombreProducto = producto.Nombre;
                string tipo = m is Ingreso ? "Ingreso" : $"Egreso - {((Egreso)m).Tipo}";

                string precio = m is Ingreso ingreso
                    ? ingreso.PrecioCompra.ToString("C") 
                    : producto.PrecioVenta.ToString("C");

                dgvMovimientos.Rows.Add(m.IdMovimiento, nombreProducto, m.Fecha.ToShortDateString(), tipo, m.Cantidad, precio);
            }
        }

        private void RecargarCombosProductos()
        {
            var disponibles = repoProductos.Listar().Where(p => p.Disponible).OrderBy(p => p.Nombre).ToList();

            cmbProductosIngreso.DataSource = null;
            cmbProductosIngreso.DataSource = new List<Producto>(disponibles);
            cmbProductosIngreso.DisplayMember = "Nombre";
            cmbProductosIngreso.ValueMember = "IdProducto";

            cmbProductosEgreso.DataSource = null;
            cmbProductosEgreso.DataSource = new List<Producto>(disponibles);
            cmbProductosEgreso.DisplayMember = "Nombre";
            cmbProductosEgreso.ValueMember = "IdProducto";
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            var movimientos = repoMovimientos.Listar();

            // Filtro por producto
            if (cmbFiltroProducto.SelectedItem is Producto prod)
                movimientos = movimientos.Where(m => m.IdProducto == prod.IdProducto).ToList();

            // Filtro por tipo
            switch (cmbFiltroTipo.SelectedItem?.ToString())
            {
                case "Ingreso":
                    movimientos = movimientos.Where(m => m is Ingreso).ToList();
                    break;
                case "Egreso":
                    movimientos = movimientos.Where(m => m is Egreso).ToList();
                    break;
            }

            // Filtro por rango de fechas (solo si los CheckBox están tildados)
            if (dtpDesde.Checked)
            {
                DateTime desde = dtpDesde.Value.Date;
                movimientos = movimientos.Where(m => m.Fecha >= desde).ToList();
            }

            if (dtpHasta.Checked)
            {
                DateTime hasta = dtpHasta.Value.Date.AddDays(1).AddTicks(-1);
                movimientos = movimientos.Where(m => m.Fecha <= hasta).ToList();
            }

            CargarMovimientosFiltrados(movimientos);
        }

        private void CargarMovimientosFiltrados(List<Movimiento> lista)
        {
            dgvMovimientos.Rows.Clear();

            foreach (var m in lista)
            {
                var producto = repoProductos.BuscarPorId(m.IdProducto);
                string nombreProducto = producto.Nombre;
                string tipo = m is Ingreso ? "Ingreso" : $"Egreso - {((Egreso)m).Tipo}";

                string precio = m is Ingreso ingreso
                    ? ingreso.PrecioCompra.ToString("C")
                    : producto.PrecioVenta.ToString("C");
                dgvMovimientos.Rows.Add(m.IdMovimiento, nombreProducto, m.Fecha.ToShortDateString(), tipo, m.Cantidad);
            }
        }

        private void btnLimpiarFiltros_Click(object sender, EventArgs e)
        {
            cmbFiltroProducto.SelectedIndex = -1;
            cmbFiltroTipo.SelectedIndex = 0;

            dtpDesde.Value = DateTime.Today.AddMonths(-1);
            dtpDesde.Checked = false;

            dtpHasta.Value = DateTime.Today;
            dtpHasta.Checked = false;

            ActualizarGridMovimientos();
        }
    }
}
