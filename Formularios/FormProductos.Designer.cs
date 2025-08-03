namespace Sistema_Gestion_de_Stock.Formularios
{
    partial class FormProductos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgvProductos = new DataGridView();
            gbDatos = new GroupBox();
            chkMostrarBajas = new CheckBox();
            nudCantidad = new NumericUpDown();
            lblCantidad = new Label();
            btnCopiarProducto = new Button();
            btnLimpiarProductos = new Button();
            btnEliminarProducto = new Button();
            btnModificarProducto = new Button();
            btnAgregarProducto = new Button();
            lblRubro = new Label();
            cmbRubros = new ComboBox();
            nudPrecio = new NumericUpDown();
            lblPrecio = new Label();
            lblDescripcion = new Label();
            lblNombre = new Label();
            txtDescripcion = new TextBox();
            txtNombre = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
            gbDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudCantidad).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudPrecio).BeginInit();
            SuspendLayout();
            // 
            // dgvProductos
            // 
            dgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductos.Location = new Point(11, 250);
            dgvProductos.MultiSelect = false;
            dgvProductos.Name = "dgvProductos";
            dgvProductos.ReadOnly = true;
            dgvProductos.RowHeadersWidth = 51;
            dgvProductos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProductos.Size = new Size(896, 302);
            dgvProductos.TabIndex = 0;
            dgvProductos.SelectionChanged += dgvProductos_SelectionChanged;
            // 
            // gbDatos
            // 
            gbDatos.Controls.Add(chkMostrarBajas);
            gbDatos.Controls.Add(nudCantidad);
            gbDatos.Controls.Add(lblCantidad);
            gbDatos.Controls.Add(btnCopiarProducto);
            gbDatos.Controls.Add(btnLimpiarProductos);
            gbDatos.Controls.Add(btnEliminarProducto);
            gbDatos.Controls.Add(btnModificarProducto);
            gbDatos.Controls.Add(btnAgregarProducto);
            gbDatos.Controls.Add(lblRubro);
            gbDatos.Controls.Add(cmbRubros);
            gbDatos.Controls.Add(nudPrecio);
            gbDatos.Controls.Add(lblPrecio);
            gbDatos.Controls.Add(lblDescripcion);
            gbDatos.Controls.Add(lblNombre);
            gbDatos.Controls.Add(txtDescripcion);
            gbDatos.Controls.Add(txtNombre);
            gbDatos.Location = new Point(12, 12);
            gbDatos.Name = "gbDatos";
            gbDatos.Size = new Size(895, 224);
            gbDatos.TabIndex = 1;
            gbDatos.TabStop = false;
            gbDatos.Text = "Datos Producto";
            // 
            // chkMostrarBajas
            // 
            chkMostrarBajas.AutoSize = true;
            chkMostrarBajas.CheckAlign = ContentAlignment.MiddleRight;
            chkMostrarBajas.Location = new Point(22, 184);
            chkMostrarBajas.Name = "chkMostrarBajas";
            chkMostrarBajas.Size = new Size(315, 24);
            chkMostrarBajas.TabIndex = 18;
            chkMostrarBajas.Text = "Mostrar también productos dados de baja ";
            chkMostrarBajas.UseVisualStyleBackColor = true;
            chkMostrarBajas.CheckedChanged += chkMostrarBajas_CheckedChanged;
            // 
            // nudCantidad
            // 
            nudCantidad.Location = new Point(545, 83);
            nudCantidad.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            nudCantidad.Name = "nudCantidad";
            nudCantidad.Size = new Size(132, 27);
            nudCantidad.TabIndex = 17;
            // 
            // lblCantidad
            // 
            lblCantidad.AutoSize = true;
            lblCantidad.Location = new Point(398, 85);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new Size(115, 20);
            lblCantidad.TabIndex = 16;
            lblCantidad.Text = "Cantidad Inicial:";
            // 
            // btnCopiarProducto
            // 
            btnCopiarProducto.Enabled = false;
            btnCopiarProducto.Location = new Point(550, 176);
            btnCopiarProducto.Name = "btnCopiarProducto";
            btnCopiarProducto.Size = new Size(127, 39);
            btnCopiarProducto.TabIndex = 15;
            btnCopiarProducto.Text = "Copiar";
            btnCopiarProducto.UseVisualStyleBackColor = true;
            btnCopiarProducto.Click += btnCopiarProducto_Click;
            // 
            // btnLimpiarProductos
            // 
            btnLimpiarProductos.Location = new Point(398, 176);
            btnLimpiarProductos.Name = "btnLimpiarProductos";
            btnLimpiarProductos.Size = new Size(127, 39);
            btnLimpiarProductos.TabIndex = 14;
            btnLimpiarProductos.Text = "Limpiar";
            btnLimpiarProductos.UseVisualStyleBackColor = true;
            btnLimpiarProductos.Click += btnLimpiarProductos_Click;
            // 
            // btnEliminarProducto
            // 
            btnEliminarProducto.Enabled = false;
            btnEliminarProducto.Location = new Point(729, 165);
            btnEliminarProducto.Name = "btnEliminarProducto";
            btnEliminarProducto.Size = new Size(132, 48);
            btnEliminarProducto.TabIndex = 13;
            btnEliminarProducto.Text = "Eliminar";
            btnEliminarProducto.UseVisualStyleBackColor = true;
            btnEliminarProducto.Click += btnEliminarProducto_Click;
            // 
            // btnModificarProducto
            // 
            btnModificarProducto.Enabled = false;
            btnModificarProducto.Location = new Point(729, 101);
            btnModificarProducto.Name = "btnModificarProducto";
            btnModificarProducto.Size = new Size(132, 48);
            btnModificarProducto.TabIndex = 12;
            btnModificarProducto.Text = "Modificar";
            btnModificarProducto.UseVisualStyleBackColor = true;
            btnModificarProducto.Click += btnModificarProducto_Click;
            // 
            // btnAgregarProducto
            // 
            btnAgregarProducto.Location = new Point(729, 37);
            btnAgregarProducto.Name = "btnAgregarProducto";
            btnAgregarProducto.Size = new Size(132, 48);
            btnAgregarProducto.TabIndex = 11;
            btnAgregarProducto.Text = "Agregar";
            btnAgregarProducto.UseVisualStyleBackColor = true;
            btnAgregarProducto.Click += btnAgregarProducto_Click;
            // 
            // lblRubro
            // 
            lblRubro.AutoSize = true;
            lblRubro.Location = new Point(398, 131);
            lblRubro.Name = "lblRubro";
            lblRubro.Size = new Size(52, 20);
            lblRubro.TabIndex = 9;
            lblRubro.Text = "Rubro:";
            // 
            // cmbRubros
            // 
            cmbRubros.FormattingEnabled = true;
            cmbRubros.Location = new Point(500, 128);
            cmbRubros.Name = "cmbRubros";
            cmbRubros.Size = new Size(177, 28);
            cmbRubros.TabIndex = 8;
            // 
            // nudPrecio
            // 
            nudPrecio.Location = new Point(545, 37);
            nudPrecio.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            nudPrecio.Name = "nudPrecio";
            nudPrecio.Size = new Size(132, 27);
            nudPrecio.TabIndex = 7;
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Location = new Point(398, 39);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(110, 20);
            lblPrecio.TabIndex = 5;
            lblPrecio.Text = "Precio Unitario:";
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.Location = new Point(22, 80);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(90, 20);
            lblDescripcion.TabIndex = 3;
            lblDescripcion.Text = "Descripcion:";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(22, 39);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(67, 20);
            lblNombre.TabIndex = 2;
            lblNombre.Text = "Nombre:";
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(128, 74);
            txtDescripcion.Multiline = true;
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.RightToLeft = RightToLeft.No;
            txtDescripcion.Size = new Size(228, 101);
            txtDescripcion.TabIndex = 1;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(128, 36);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(228, 27);
            txtNombre.TabIndex = 0;
            // 
            // FormProductos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(923, 564);
            Controls.Add(gbDatos);
            Controls.Add(dgvProductos);
            Name = "FormProductos";
            Text = "Gestor de Productos";
            ((System.ComponentModel.ISupportInitialize)dgvProductos).EndInit();
            gbDatos.ResumeLayout(false);
            gbDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudCantidad).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudPrecio).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvProductos;
        private GroupBox gbDatos;
        private TextBox txtDescripcion;
        private TextBox txtNombre;
        private Label lblDescripcion;
        private Label lblNombre;
        private Label lblRubro;
        private ComboBox cmbRubros;
        private Button btnLimpiarProductos;
        private Button btnEliminarProducto;
        private Button btnModificarProducto;
        private Button btnAgregarProducto;
        private Button btnCopiarProducto;
        private NumericUpDown nudPrecio;
        private Label lblPrecio;
        private NumericUpDown nudCantidad;
        private Label lblCantidad;
        private CheckBox chkMostrarBajas;
    }
}