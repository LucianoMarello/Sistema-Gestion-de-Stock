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
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { gestionProductosToolStripMenuItem, gestorRubrosToolStripMenuItem, gestorProveedoresToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(896, 28);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // gestionProductosToolStripMenuItem
            // 
            gestionProductosToolStripMenuItem.Name = "gestionProductosToolStripMenuItem";
            gestionProductosToolStripMenuItem.Size = new Size(136, 24);
            gestionProductosToolStripMenuItem.Text = "Gestor Productos";
            gestionProductosToolStripMenuItem.Click += gestionProductosToolStripMenuItem_Click;
            // 
            // gestorRubrosToolStripMenuItem
            // 
            gestorRubrosToolStripMenuItem.Name = "gestorRubrosToolStripMenuItem";
            gestorRubrosToolStripMenuItem.Size = new Size(116, 24);
            gestorRubrosToolStripMenuItem.Text = "Gestor Rubros";
            gestorRubrosToolStripMenuItem.Click += gestorRubrosToolStripMenuItem_Click;
            // 
            // gestorProveedoresToolStripMenuItem
            // 
            gestorProveedoresToolStripMenuItem.Name = "gestorProveedoresToolStripMenuItem";
            gestorProveedoresToolStripMenuItem.Size = new Size(152, 24);
            gestorProveedoresToolStripMenuItem.Text = "Gestor Proveedores";
            gestorProveedoresToolStripMenuItem.Click += gestorProveedoresToolStripMenuItem_Click;
            // 
            // FormMenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(896, 576);
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
    }
}
