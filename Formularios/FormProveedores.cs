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
    public partial class FormProveedores : Form
    {
        private RepositorioProveedor repoProveedores;

        public FormProveedores()
        {
            InitializeComponent();
            repoProveedores = new RepositorioProveedor();
            CargarProveedores();

            btnModificar.Enabled = false;
            btnEliminar.Enabled = false;
            btnCopiar.Enabled = false;
        }

        private void CargarProveedores()
        {
            dgvProveedores.Rows.Clear();
            dgvProveedores.Columns.Clear();

            dgvProveedores.Columns.Add("IdProveedor", "ID");
            dgvProveedores.Columns.Add("Nombre", "Nombre");
            dgvProveedores.Columns.Add("Contacto", "Contacto");
            dgvProveedores.Columns.Add("Telefono", "Teléfono");
            dgvProveedores.Columns.Add("Direccion", "Dirección");

            foreach (var p in repoProveedores.Listar())
            {
                dgvProveedores.Rows.Add(
                    p.IdProveedor,
                    p.Nombre,
                    p.Contacto,
                    p.Telefono,
                    p.Direccion
                );
            }

            dgvProveedores.ClearSelection();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos()) return;

            var nuevo = new Proveedor(
                GenerarNuevoId(),
                txtNombre.Text,
                txtContacto.Text,
                txtTelefono.Text,
                txtDireccion.Text
            );

            repoProveedores.Agregar(nuevo);
            CargarProveedores();
            LimpiarCampos();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgvProveedores.SelectedRows.Count == 0) return;

            int id = (int)dgvProveedores.SelectedRows[0].Cells["IdProveedor"].Value;
            var proveedor = repoProveedores.BuscarPorId(id);

            proveedor.Nombre = txtNombre.Text;
            proveedor.Contacto = txtContacto.Text;
            proveedor.Telefono = txtTelefono.Text;
            proveedor.Direccion = txtDireccion.Text;

            repoProveedores.Modificar(proveedor);
            CargarProveedores();
            LimpiarCampos();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvProveedores.SelectedRows.Count == 0) return;

            int id = (int)dgvProveedores.SelectedRows[0].Cells["IdProveedor"].Value;

            var confirm = MessageBox.Show("¿Seguro que desea eliminar este proveedor?", "Confirmar", MessageBoxButtons.YesNo);
            if (confirm == DialogResult.Yes)
            {
                repoProveedores.Eliminar(id);
                CargarProveedores();
                LimpiarCampos();
            }
        }

        private void btnCopiar_Click(object sender, EventArgs e)
        {
            if (dgvProveedores.SelectedRows.Count == 0) return;

            var row = dgvProveedores.SelectedRows[0];

            txtNombre.Text = row.Cells["Nombre"].Value.ToString();
            txtContacto.Text = row.Cells["Contacto"].Value.ToString();
            txtTelefono.Text = row.Cells["Telefono"].Value.ToString();
            txtDireccion.Text = row.Cells["Direccion"].Value.ToString();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void dgvProveedores_SelectionChanged(object sender, EventArgs e)
        {
            bool haySeleccion = dgvProveedores.SelectedRows.Count > 0;

            btnModificar.Enabled = haySeleccion;
            btnEliminar.Enabled = haySeleccion;
            btnCopiar.Enabled = haySeleccion;
        }

        private void LimpiarCampos()
        {
            txtNombre.Clear();
            txtContacto.Clear();
            txtTelefono.Clear();
            txtDireccion.Clear();

            dgvProveedores.ClearSelection();
            btnModificar.Enabled = false;
            btnEliminar.Enabled = false;
            btnCopiar.Enabled = false;
        }

        private bool ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text) ||
                string.IsNullOrWhiteSpace(txtContacto.Text) ||
                string.IsNullOrWhiteSpace(txtTelefono.Text) ||
                !double.TryParse(txtTelefono.Text, out _))
            {
                MessageBox.Show("Campos obligatorios incompletos o inválidos.");
                return false;
            }
            return true;
        }

        private int GenerarNuevoId()
        {
            var lista = repoProveedores.Listar();
            return lista.Any() ? lista.Max(p => p.IdProveedor) + 1 : 1;
        }
    }
}
