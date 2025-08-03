using Sistema_Gestion_de_Stock.Formularios;

namespace Sistema_Gestion_de_Stock
{
    public partial class FormMenuPrincipal : Form
    {
        public FormMenuPrincipal()
        {
            InitializeComponent();
            IsMdiContainer = true;
        }

        private void gestionProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormProductos form = new FormProductos();
            AbrirFormulario(form);
        }

        private void AbrirFormulario(Form formHijo)
        {
            formHijo.MdiParent = this;
            formHijo.WindowState = FormWindowState.Maximized;
            formHijo.Show();
        }
    }
}
