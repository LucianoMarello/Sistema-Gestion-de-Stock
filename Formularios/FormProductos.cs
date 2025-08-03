using Sistema_Gestion_de_Stock.Entidades;
using Sistema_Gestion_de_Stock.Repositorios;
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
        public FormProductos()
        {
            InitializeComponent();
            repoProductos = new RepositorioProducto();
            repoRubros = new RepositorioRubro();

            CargarRubros();
            CargarProductos();
        }

        private void CargarRubros()
        {
            var rubros = repoRubros.Listar();
            cmbRubros.DataSource = rubros;
            cmbRubros.DisplayMember = "Categoria";
            cmbRubros.ValueMember = "IdRubro";
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
            dgvProductos.Columns.Add("Disponible", "Disponible");

            bool mostrarInactivos = chkMostrarBajas.Checked;

            var productos = mostrarInactivos ? repoProductos.Listar() : repoProductos.Listar().Where(p => p.Disponible);

            foreach (var p in productos)
            {
                var rubro = repoRubros.BuscarPorId(p.IdRubro);
                string nombreRubro = rubro != null ? rubro.Categoria: "Sin Rubro";

                int rowIndex = dgvProductos.Rows.Add(p.IdProducto, p.Nombre, p.Descripcion, p.PrecioVenta, p.CalcularStockTotal(), nombreRubro, p.Disponible ? "Sí" : "No");

                if (!p.Disponible)
                {
                    dgvProductos.Rows[rowIndex].DefaultCellStyle.ForeColor = Color.Gray;
                }
            }

            dgvProductos.ClearSelection();
        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos()) return;

            var nuevo = new Producto(
                GenerarNuevoId(),
                txtNombre.Text,
                txtDescripcion.Text,
                (double)nudPrecio.Value,
                ((Rubro)cmbRubros.SelectedItem).IdRubro,
                true
                );

            repoProductos.Agregar(nuevo);
            CargarProductos();
            LimpiarCampos();
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
            producto.PrecioVenta = (int)nudPrecio.Value * 1.5;
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

        private void chkMostrarBajas_CheckedChanged(object sender, EventArgs e)
        {
            CargarProductos();
        }
    }
}
