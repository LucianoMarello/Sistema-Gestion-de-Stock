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
    public partial class FormRubros : Form
    {
        private RepositorioRubro repoRubros;

        public FormRubros()
        {
            InitializeComponent();
            repoRubros = new RepositorioRubro();
            CargarRubros();

            btnModificar.Enabled = false;
            btnEliminar.Enabled = false;
            btnCopiar.Enabled = false;
        }

        private void CargarRubros()
        {
            dgvRubros.Rows.Clear();
            dgvRubros.Columns.Clear();

            dgvRubros.Columns.Add("IdRubro", "ID");
            dgvRubros.Columns.Add("Categoria", "Categoría");
            dgvRubros.Columns.Add("Descripcion", "Descripción");

            foreach (var r in repoRubros.Listar())
            {
                dgvRubros.Rows.Add(r.IdRubro, r.Categoria, r.Descripcion);
            }

            dgvRubros.ClearSelection();
        }

        private void btnAgregarCategoria_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDescripcion.Text))
            {
                MessageBox.Show("La categoría es obligatoria.");
                return;
            }

            var nuevo = new Rubro(
                GenerarNuevoId(),
                txtCategoria.Text,
                txtDescripcion.Text
            );

            repoRubros.Agregar(nuevo);
            CargarRubros();
            LimpiarCampos();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgvRubros.SelectedRows.Count == 0) return;

            int id = (int)dgvRubros.SelectedRows[0].Cells["IdRubro"].Value;

            var rubro = repoRubros.BuscarPorId(id);
            rubro.Categoria = txtCategoria.Text;
            rubro.Descripcion = txtDescripcion.Text;

            repoRubros.Modificar(rubro);
            CargarRubros();
            LimpiarCampos();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvRubros.SelectedRows.Count == 0) return;

            int id = (int)dgvRubros.SelectedRows[0].Cells["IdRubro"].Value;

            var confirm = MessageBox.Show("¿Seguro que desea eliminar este rubro?", "Confirmar", MessageBoxButtons.YesNo);
            if (confirm == DialogResult.Yes)
            {
                repoRubros.Eliminar(id);
                CargarRubros();
                LimpiarCampos();
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void btnCopiar_Click(object sender, EventArgs e)
        {
            if (dgvRubros.SelectedRows.Count == 0) return;

            var fila = dgvRubros.SelectedRows[0];
            txtCategoria.Text = fila.Cells["Categoria"].Value.ToString();
            txtDescripcion.Text = fila.Cells["Descripcion"].Value.ToString();
        }

        private void dgvRubros_SelectionChanged(object sender, EventArgs e)
        {
            bool haySeleccion = dgvRubros.SelectedRows.Count > 0;
            btnModificar.Enabled = haySeleccion;
            btnEliminar.Enabled = haySeleccion;
            btnCopiar.Enabled = haySeleccion;
        }

        private void LimpiarCampos()
        {
            txtCategoria.Clear();
            txtDescripcion.Clear();
            dgvRubros.ClearSelection();
        }

        private int GenerarNuevoId()
        {
            var lista = repoRubros.Listar();
            return lista.Any() ? lista.Max(r => r.IdRubro) + 1 : 1;
        }
    }
}
