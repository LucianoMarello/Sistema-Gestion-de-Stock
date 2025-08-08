namespace Sistema_Gestion_de_Stock
{
    partial class FormMenuPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            gestionProductosToolStripMenuItem = new ToolStripMenuItem();
            gestorRubrosToolStripMenuItem = new ToolStripMenuItem();
            gestorProveedoresToolStripMenuItem = new ToolStripMenuItem();
            movimientosToolStripMenuItem = new ToolStripMenuItem();
            reportesToolStripMenuItem = new ToolStripMenuItem();
            salirToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { gestionProductosToolStripMenuItem, gestorRubrosToolStripMenuItem, gestorProveedoresToolStripMenuItem, movimientosToolStripMenuItem, reportesToolStripMenuItem, salirToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1042, 28);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // gestionProductosToolStripMenuItem
            // 
            gestionProductosToolStripMenuItem.Name = "gestionProductosToolStripMenuItem";
            gestionProductosToolStripMenuItem.Size = new Size(89, 24);
            gestionProductosToolStripMenuItem.Text = "Productos";
            gestionProductosToolStripMenuItem.Click += gestionProductosToolStripMenuItem_Click;
            // 
            // gestorRubrosToolStripMenuItem
            // 
            gestorRubrosToolStripMenuItem.Name = "gestorRubrosToolStripMenuItem";
            gestorRubrosToolStripMenuItem.Size = new Size(69, 24);
            gestorRubrosToolStripMenuItem.Text = "Rubros";
            gestorRubrosToolStripMenuItem.Click += gestorRubrosToolStripMenuItem_Click;
            // 
            // gestorProveedoresToolStripMenuItem
            // 
            gestorProveedoresToolStripMenuItem.Name = "gestorProveedoresToolStripMenuItem";
            gestorProveedoresToolStripMenuItem.Size = new Size(105, 24);
            gestorProveedoresToolStripMenuItem.Text = "Proveedores";
            gestorProveedoresToolStripMenuItem.Click += gestorProveedoresToolStripMenuItem_Click;
            // 
            // movimientosToolStripMenuItem
            // 
            movimientosToolStripMenuItem.Name = "movimientosToolStripMenuItem";
            movimientosToolStripMenuItem.Size = new Size(109, 24);
            movimientosToolStripMenuItem.Text = "Movimientos";
            movimientosToolStripMenuItem.Click += movimientosToolStripMenuItem_Click;
            // 
            // reportesToolStripMenuItem
            // 
            reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            reportesToolStripMenuItem.Size = new Size(82, 24);
            reportesToolStripMenuItem.Text = "Reportes";
            reportesToolStripMenuItem.Click += reportesToolStripMenuItem_Click;
            // 
            // salirToolStripMenuItem
            // 
            salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            salirToolStripMenuItem.Size = new Size(52, 24);
            salirToolStripMenuItem.Text = "Salir";
            salirToolStripMenuItem.Click += salirToolStripMenuItem_Click;
            // 
            // FormMenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1042, 703);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "FormMenuPrincipal";
            Text = "Sistema de Gestión de Stock";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem gestionProductosToolStripMenuItem;
        private ToolStripMenuItem gestorRubrosToolStripMenuItem;
        private ToolStripMenuItem gestorProveedoresToolStripMenuItem;
        private ToolStripMenuItem movimientosToolStripMenuItem;
        private ToolStripMenuItem reportesToolStripMenuItem;
        private ToolStripMenuItem salirToolStripMenuItem;
    }
}
