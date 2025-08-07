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
            dtpVencimiento = new DateTimePicker();
            chkVencimiento = new CheckBox();
            nudCantidad = new NumericUpDown();
            btnCopiarProducto = new Button();
            btnLimpiarProductos = new Button();
            lblCantidad = new Label();
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
            chkMostrarBajas = new CheckBox();
            txtBuscarNombre = new TextBox();
            txtBuscarID = new TextBox();
            lblBuscarNombre = new Label();
            lblBuscarID = new Label();
            cmbFiltrarRubro = new ComboBox();
            lblBuscarRubro = new Label();
            btnLimpiarFiltros = new Button();
            btnFiltrar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
            gbDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudCantidad).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudPrecio).BeginInit();
            SuspendLayout();
            // 
            // dgvProductos
            // 
            dgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductos.Location = new Point(12, 355);
            dgvProductos.MultiSelect = false;
            dgvProductos.Name = "dgvProductos";
            dgvProductos.ReadOnly = true;
            dgvProductos.RowHeadersWidth = 51;
            dgvProductos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProductos.Size = new Size(896, 287);
            dgvProductos.TabIndex = 0;
            dgvProductos.SelectionChanged += dgvProductos_SelectionChanged;
            // 
            // gbDatos
            // 
            gbDatos.Controls.Add(dtpVencimiento);
            gbDatos.Controls.Add(chkVencimiento);
            gbDatos.Controls.Add(nudCantidad);
            gbDatos.Controls.Add(btnCopiarProducto);
            gbDatos.Controls.Add(btnLimpiarProductos);
            gbDatos.Controls.Add(lblCantidad);
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
            gbDatos.Size = new Size(895, 239);
            gbDatos.TabIndex = 1;
            gbDatos.TabStop = false;
            gbDatos.Text = "Datos Producto";
            // 
            // dtpVencimiento
            // 
            dtpVencimiento.Location = new Point(398, 147);
            dtpVencimiento.Name = "dtpVencimiento";
            dtpVencimiento.Size = new Size(291, 27);
            dtpVencimiento.TabIndex = 19;
            // 
            // chkVencimiento
            // 
            chkVencimiento.AutoSize = true;
            chkVencimiento.CheckAlign = ContentAlignment.MiddleRight;
            chkVencimiento.Checked = true;
            chkVencimiento.CheckState = CheckState.Checked;
            chkVencimiento.Location = new Point(398, 117);
            chkVencimiento.Name = "chkVencimiento";
            chkVencimiento.Size = new Size(160, 24);
            chkVencimiento.TabIndex = 19;
            chkVencimiento.Text = "Tiene Vencimiento?";
            chkVencimiento.UseVisualStyleBackColor = true;
            chkVencimiento.CheckedChanged += chkVencimiento_CheckedChanged;
            // 
            // nudCantidad
            // 
            nudCantidad.Location = new Point(545, 37);
            nudCantidad.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            nudCantidad.Name = "nudCantidad";
            nudCantidad.Size = new Size(144, 27);
            nudCantidad.TabIndex = 17;
            // 
            // btnCopiarProducto
            // 
            btnCopiarProducto.Enabled = false;
            btnCopiarProducto.Location = new Point(557, 187);
            btnCopiarProducto.Name = "btnCopiarProducto";
            btnCopiarProducto.Size = new Size(127, 39);
            btnCopiarProducto.TabIndex = 15;
            btnCopiarProducto.Text = "Copiar";
            btnCopiarProducto.UseVisualStyleBackColor = true;
            btnCopiarProducto.Click += btnCopiarProducto_Click;
            // 
            // btnLimpiarProductos
            // 
            btnLimpiarProductos.Location = new Point(401, 187);
            btnLimpiarProductos.Name = "btnLimpiarProductos";
            btnLimpiarProductos.Size = new Size(127, 39);
            btnLimpiarProductos.TabIndex = 14;
            btnLimpiarProductos.Text = "Limpiar";
            btnLimpiarProductos.UseVisualStyleBackColor = true;
            btnLimpiarProductos.Click += btnLimpiarProductos_Click;
            // 
            // lblCantidad
            // 
            lblCantidad.AutoSize = true;
            lblCantidad.Location = new Point(398, 39);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new Size(115, 20);
            lblCantidad.TabIndex = 16;
            lblCantidad.Text = "Cantidad Inicial:";
            // 
            // btnEliminarProducto
            // 
            btnEliminarProducto.Enabled = false;
            btnEliminarProducto.Location = new Point(729, 169);
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
            btnModificarProducto.Location = new Point(729, 103);
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
            lblRubro.Location = new Point(22, 196);
            lblRubro.Name = "lblRubro";
            lblRubro.Size = new Size(52, 20);
            lblRubro.TabIndex = 9;
            lblRubro.Text = "Rubro:";
            // 
            // cmbRubros
            // 
            cmbRubros.FormattingEnabled = true;
            cmbRubros.Location = new Point(128, 193);
            cmbRubros.Name = "cmbRubros";
            cmbRubros.Size = new Size(228, 28);
            cmbRubros.TabIndex = 8;
            // 
            // nudPrecio
            // 
            nudPrecio.Location = new Point(545, 78);
            nudPrecio.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            nudPrecio.Name = "nudPrecio";
            nudPrecio.Size = new Size(144, 27);
            nudPrecio.TabIndex = 7;
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Location = new Point(398, 80);
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
            txtDescripcion.Size = new Size(228, 107);
            txtDescripcion.TabIndex = 1;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(128, 36);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(228, 27);
            txtNombre.TabIndex = 0;
            // 
            // chkMostrarBajas
            // 
            chkMostrarBajas.AutoSize = true;
            chkMostrarBajas.CheckAlign = ContentAlignment.MiddleRight;
            chkMostrarBajas.Location = new Point(758, 310);
            chkMostrarBajas.Name = "chkMostrarBajas";
            chkMostrarBajas.Size = new Size(131, 24);
            chkMostrarBajas.TabIndex = 18;
            chkMostrarBajas.Text = "No disponibles";
            chkMostrarBajas.UseVisualStyleBackColor = true;
            chkMostrarBajas.CheckedChanged += chkMostrarBajas_CheckedChanged;
            // 
            // txtBuscarNombre
            // 
            txtBuscarNombre.Location = new Point(199, 265);
            txtBuscarNombre.Name = "txtBuscarNombre";
            txtBuscarNombre.Size = new Size(169, 27);
            txtBuscarNombre.TabIndex = 20;
            // 
            // txtBuscarID
            // 
            txtBuscarID.Location = new Point(199, 305);
            txtBuscarID.Name = "txtBuscarID";
            txtBuscarID.Size = new Size(169, 27);
            txtBuscarID.TabIndex = 21;
            // 
            // lblBuscarNombre
            // 
            lblBuscarNombre.AutoSize = true;
            lblBuscarNombre.Location = new Point(34, 268);
            lblBuscarNombre.Name = "lblBuscarNombre";
            lblBuscarNombre.Size = new Size(141, 20);
            lblBuscarNombre.TabIndex = 20;
            lblBuscarNombre.Text = "Buscar por Nombre:";
            // 
            // lblBuscarID
            // 
            lblBuscarID.AutoSize = true;
            lblBuscarID.Location = new Point(34, 308);
            lblBuscarID.Name = "lblBuscarID";
            lblBuscarID.Size = new Size(101, 20);
            lblBuscarID.TabIndex = 22;
            lblBuscarID.Text = "Buscar por ID:";
            // 
            // cmbFiltrarRubro
            // 
            cmbFiltrarRubro.FormattingEnabled = true;
            cmbFiltrarRubro.Location = new Point(569, 265);
            cmbFiltrarRubro.Name = "cmbFiltrarRubro";
            cmbFiltrarRubro.Size = new Size(169, 28);
            cmbFiltrarRubro.TabIndex = 20;
            // 
            // lblBuscarRubro
            // 
            lblBuscarRubro.AutoSize = true;
            lblBuscarRubro.Location = new Point(399, 268);
            lblBuscarRubro.Name = "lblBuscarRubro";
            lblBuscarRubro.Size = new Size(126, 20);
            lblBuscarRubro.TabIndex = 23;
            lblBuscarRubro.Text = "Buscar por Rubro:";
            // 
            // btnLimpiarFiltros
            // 
            btnLimpiarFiltros.Location = new Point(430, 305);
            btnLimpiarFiltros.Name = "btnLimpiarFiltros";
            btnLimpiarFiltros.Size = new Size(121, 33);
            btnLimpiarFiltros.TabIndex = 20;
            btnLimpiarFiltros.Text = "Limpiar";
            btnLimpiarFiltros.UseVisualStyleBackColor = true;
            btnLimpiarFiltros.Click += btnLimpiarFiltros_Click;
            // 
            // btnFiltrar
            // 
            btnFiltrar.Location = new Point(575, 305);
            btnFiltrar.Name = "btnFiltrar";
            btnFiltrar.Size = new Size(121, 33);
            btnFiltrar.TabIndex = 24;
            btnFiltrar.Text = "Filtrar";
            btnFiltrar.UseVisualStyleBackColor = true;
            btnFiltrar.Click += btnFiltrar_Click;
            // 
            // FormProductos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(930, 654);
            Controls.Add(btnFiltrar);
            Controls.Add(btnLimpiarFiltros);
            Controls.Add(lblBuscarRubro);
            Controls.Add(cmbFiltrarRubro);
            Controls.Add(lblBuscarID);
            Controls.Add(lblBuscarNombre);
            Controls.Add(txtBuscarID);
            Controls.Add(txtBuscarNombre);
            Controls.Add(chkMostrarBajas);
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
            PerformLayout();
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
        private CheckBox chkMostrarBajas;
        private NumericUpDown nudCantidad;
        private Label lblCantidad;
        private DateTimePicker dtpVencimiento;
        private CheckBox chkVencimiento;
        private TextBox txtBuscarNombre;
        private TextBox txtBuscarID;
        private Label lblBuscarNombre;
        private Label lblBuscarID;
        private ComboBox cmbFiltrarRubro;
        private Label lblBuscarRubro;
        private Button btnLimpiarFiltros;
        private Button btnFiltrar;
    }
}