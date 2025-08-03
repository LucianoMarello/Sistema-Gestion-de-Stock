namespace Sistema_Gestion_de_Stock.Formularios
{
    partial class FormRubros
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
            dgvRubros = new DataGridView();
            txtCategoria = new TextBox();
            txtDescripcion = new TextBox();
            gbRubro = new GroupBox();
            btnCopiar = new Button();
            btnLimpiar = new Button();
            btnModificar = new Button();
            btnEliminar = new Button();
            btnAgregar = new Button();
            lblCategoria = new Label();
            lblDescripcion = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvRubros).BeginInit();
            gbRubro.SuspendLayout();
            SuspendLayout();
            // 
            // dgvRubros
            // 
            dgvRubros.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRubros.Location = new Point(388, 21);
            dgvRubros.Name = "dgvRubros";
            dgvRubros.RowHeadersWidth = 51;
            dgvRubros.Size = new Size(501, 379);
            dgvRubros.TabIndex = 0;
            dgvRubros.SelectionChanged += dgvRubros_SelectionChanged;
            // 
            // txtCategoria
            // 
            txtCategoria.Location = new Point(135, 39);
            txtCategoria.Name = "txtCategoria";
            txtCategoria.Size = new Size(203, 27);
            txtCategoria.TabIndex = 1;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(135, 91);
            txtDescripcion.Multiline = true;
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(203, 97);
            txtDescripcion.TabIndex = 2;
            // 
            // gbRubro
            // 
            gbRubro.Controls.Add(btnCopiar);
            gbRubro.Controls.Add(btnLimpiar);
            gbRubro.Controls.Add(btnModificar);
            gbRubro.Controls.Add(btnEliminar);
            gbRubro.Controls.Add(btnAgregar);
            gbRubro.Controls.Add(lblCategoria);
            gbRubro.Controls.Add(lblDescripcion);
            gbRubro.Controls.Add(txtCategoria);
            gbRubro.Controls.Add(txtDescripcion);
            gbRubro.Location = new Point(12, 12);
            gbRubro.Name = "gbRubro";
            gbRubro.Size = new Size(358, 388);
            gbRubro.TabIndex = 3;
            gbRubro.TabStop = false;
            gbRubro.Text = "Ingreso Datos Rubros";
            // 
            // btnCopiar
            // 
            btnCopiar.Location = new Point(199, 262);
            btnCopiar.Name = "btnCopiar";
            btnCopiar.Size = new Size(127, 46);
            btnCopiar.TabIndex = 9;
            btnCopiar.Text = "Copiar";
            btnCopiar.UseVisualStyleBackColor = true;
            btnCopiar.Click += btnCopiar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(199, 205);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(127, 46);
            btnLimpiar.TabIndex = 8;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(35, 262);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(127, 46);
            btnModificar.TabIndex = 7;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(35, 324);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(127, 46);
            btnEliminar.TabIndex = 6;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(35, 205);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(127, 46);
            btnAgregar.TabIndex = 5;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregarCategoria_Click;
            // 
            // lblCategoria
            // 
            lblCategoria.AutoSize = true;
            lblCategoria.Location = new Point(21, 42);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Size = new Size(77, 20);
            lblCategoria.TabIndex = 4;
            lblCategoria.Text = "Categoria:";
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.Location = new Point(21, 91);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(90, 20);
            lblDescripcion.TabIndex = 3;
            lblDescripcion.Text = "Descripcion:";
            // 
            // FormRubros
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(901, 419);
            Controls.Add(gbRubro);
            Controls.Add(dgvRubros);
            Name = "FormRubros";
            Text = "Gestor de Rubros";
            ((System.ComponentModel.ISupportInitialize)dgvRubros).EndInit();
            gbRubro.ResumeLayout(false);
            gbRubro.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvRubros;
        private TextBox txtCategoria;
        private TextBox txtDescripcion;
        private GroupBox gbRubro;
        private Label lblCategoria;
        private Label lblDescripcion;
        private Button btnEliminar;
        private Button btnAgregar;
        private Button btnModificar;
        private Button btnCopiar;
        private Button btnLimpiar;
    }
}