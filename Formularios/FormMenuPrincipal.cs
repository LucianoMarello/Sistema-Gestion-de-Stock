using Sistema_Gestion_de_Stock.Formularios;

namespace Sistema_Gestion_de_Stock
{
    public partial class FormMenuPrincipal : Form
    {
        private Form formularioActivo = null;

        public FormMenuPrincipal()
        {
            InitializeComponent();
            IsMdiContainer = true;
        }

        private void AbrirFormulario(Form formHijo)
        {
            // Cierra el formulario activo si ya hay uno abierto
            if (formularioActivo != null)
                formularioActivo.Close();

            formularioActivo = formHijo;
            formularioActivo.MdiParent = this;
            formularioActivo.FormBorderStyle = FormBorderStyle.None;
            formularioActivo.Dock = DockStyle.Fill;
            formularioActivo.Show();
        }

        private void gestionProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FormProductos());
        }

        private void gestorRubrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FormRubros());
        }

        private void gestorProveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FormProveedores());
        }

        private void movimientosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FormMovimientos());
        }

        private void reportesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FormReportes());
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }

}
