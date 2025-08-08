namespace Sistema_Gestion_de_Stock.Formularios
{
    partial class FormProveedores
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
            dgvProveedores = new DataGridView();
            gbProveedores = new GroupBox();
            txtTelefono = new TextBox();
            btnCopiar = new Button();
            btnLimpiar = new Button();
            btnEliminar = new Button();
            btnModificar = new Button();
            btnAgregar = new Button();
            lblDireccion = new Label();
            lblTelefono = new Label();
            lblContacto = new Label();
            lblNombre = new Label();
            txtDireccion = new TextBox();
            txtContacto = new TextBox();
            txtNombre = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvProveedores).BeginInit();
            gbProveedores.SuspendLayout();
            SuspendLayout();
            // 
            // dgvProveedores
            // 
            dgvProveedores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProveedores.Location = new Point(12, 251);
            dgvProveedores.Name = "dgvProveedores";
            dgvProveedores.RowHeadersWidth = 51;
            dgvProveedores.Size = new Size(696, 273);
            dgvProveedores.TabIndex = 0;
            dgvProveedores.SelectionChanged += dgvProveedores_SelectionChanged;
            // 
            // gbProveedores
            // 
            gbProveedores.Controls.Add(txtTelefono);
            gbProveedores.Controls.Add(btnCopiar);
            gbProveedores.Controls.Add(btnLimpiar);
            gbProveedores.Controls.Add(btnEliminar);
            gbProveedores.Controls.Add(btnModificar);
            gbProveedores.Controls.Add(btnAgregar);
            gbProveedores.Controls.Add(lblDireccion);
            gbProveedores.Controls.Add(lblTelefono);
            gbProveedores.Controls.Add(lblContacto);
            gbProveedores.Controls.Add(lblNombre);
            gbProveedores.Controls.Add(txtDireccion);
            gbProveedores.Controls.Add(txtContacto);
            gbProveedores.Controls.Add(txtNombre);
            gbProveedores.Location = new Point(12, 12);
            gbProveedores.Name = "gbProveedores";
            gbProveedores.Size = new Size(696, 233);
            gbProveedores.TabIndex = 1;
            gbProveedores.TabStop = false;
            gbProveedores.Text = "Datos Proveedores";
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(132, 139);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(205, 27);
            txtTelefono.TabIndex = 13;
            // 
            // btnCopiar
            // 
            btnCopiar.Location = new Point(552, 106);
            btnCopiar.Name = "btnCopiar";
            btnCopiar.Size = new Size(114, 42);
            btnCopiar.TabIndex = 12;
            btnCopiar.Text = "Copiar";
            btnCopiar.UseVisualStyleBackColor = true;
            btnCopiar.Click += btnCopiar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(552, 45);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(114, 42);
            btnLimpiar.TabIndex = 11;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(395, 168);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(114, 42);
            btnEliminar.TabIndex = 10;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(395, 106);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(114, 42);
            btnModificar.TabIndex = 9;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(395, 44);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(114, 42);
            btnAgregar.TabIndex = 8;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // lblDireccion
            // 
            lblDireccion.AutoSize = true;
            lblDireccion.Location = new Point(31, 191);
            lblDireccion.Name = "lblDireccion";
            lblDireccion.Size = new Size(75, 20);
            lblDireccion.TabIndex = 7;
            lblDireccion.Text = "Direccion:";
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Location = new Point(31, 142);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(70, 20);
            lblTelefono.TabIndex = 6;
            lblTelefono.Text = "Teléfono:";
            // 
            // lblContacto
            // 
            lblContacto.AutoSize = true;
            lblContacto.Location = new Point(31, 93);
            lblContacto.Name = "lblContacto";
            lblContacto.Size = new Size(72, 20);
            lblContacto.TabIndex = 5;
            lblContacto.Text = "Contacto:";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(31, 44);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(67, 20);
            lblNombre.TabIndex = 4;
            lblNombre.Text = "Nombre:";
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(132, 188);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(205, 27);
            txtDireccion.TabIndex = 3;
            // 
            // txtContacto
            // 
            txtContacto.Location = new Point(132, 90);
            txtContacto.Name = "txtContacto";
            txtContacto.Size = new Size(205, 27);
            txtContacto.TabIndex = 1;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(132, 41);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(205, 27);
            txtNombre.TabIndex = 0;
            // 
            // FormProveedores
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(722, 536);
            Controls.Add(gbProveedores);
            Controls.Add(dgvProveedores);
            Name = "FormProveedores";
            Text = "Menú Proveedores";
            ((System.ComponentModel.ISupportInitialize)dgvProveedores).EndInit();
            gbProveedores.ResumeLayout(false);
            gbProveedores.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvProveedores;
        private GroupBox gbProveedores;
        private Button btnCopiar;
        private Button btnLimpiar;
        private Button btnEliminar;
        private Button btnModificar;
        private Button btnAgregar;
        private Label lblDireccion;
        private Label lblTelefono;
        private Label lblContacto;
        private Label lblNombre;
        private TextBox txtDireccion;
        private TextBox txtContacto;
        private TextBox txtNombre;
        private TextBox txtTelefono;
    }
}