namespace Sistema_Gestion_de_Stock.Formularios
{
    partial class FormMovimientos
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
            tabMovimientos = new TabControl();
            tpIngreso = new TabPage();
            btnRegistrarIngreso = new Button();
            chkVencimiento = new CheckBox();
            lblProveedor = new Label();
            lblPrecio = new Label();
            lblCantidadIngreso = new Label();
            lblProductoIngreso = new Label();
            dtpVencimiento = new DateTimePicker();
            cmbProveedor = new ComboBox();
            nudPrecio = new NumericUpDown();
            nudCantidadIngreso = new NumericUpDown();
            cmbProductosIngreso = new ComboBox();
            tpEgreso = new TabPage();
            btnRegistrarEgreso = new Button();
            cmbProductosEgreso = new ComboBox();
            nudCantidadEgreso = new NumericUpDown();
            lblTipoEgreso = new Label();
            lblCantidadEgreso = new Label();
            cmbTipoEgreso = new ComboBox();
            lblProductosEgreso = new Label();
            dgvMovimientos = new DataGridView();
            lblMovimientos = new Label();
            cmbFiltroProducto = new ComboBox();
            cmbFiltroTipo = new ComboBox();
            gbFiltros = new GroupBox();
            btnLimpiarFiltros = new Button();
            chkHasta = new CheckBox();
            chkDesde = new CheckBox();
            lblFiltroTipo = new Label();
            lblFiltroProducto = new Label();
            btnFiltrar = new Button();
            dtpHasta = new DateTimePicker();
            dtpDesde = new DateTimePicker();
            tabMovimientos.SuspendLayout();
            tpIngreso.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudPrecio).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudCantidadIngreso).BeginInit();
            tpEgreso.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudCantidadEgreso).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvMovimientos).BeginInit();
            gbFiltros.SuspendLayout();
            SuspendLayout();
            // 
            // tabMovimientos
            // 
            tabMovimientos.Controls.Add(tpIngreso);
            tabMovimientos.Controls.Add(tpEgreso);
            tabMovimientos.Location = new Point(12, 12);
            tabMovimientos.Name = "tabMovimientos";
            tabMovimientos.SelectedIndex = 0;
            tabMovimientos.Size = new Size(383, 339);
            tabMovimientos.TabIndex = 0;
            // 
            // tpIngreso
            // 
            tpIngreso.Controls.Add(btnRegistrarIngreso);
            tpIngreso.Controls.Add(chkVencimiento);
            tpIngreso.Controls.Add(lblProveedor);
            tpIngreso.Controls.Add(lblPrecio);
            tpIngreso.Controls.Add(lblCantidadIngreso);
            tpIngreso.Controls.Add(lblProductoIngreso);
            tpIngreso.Controls.Add(dtpVencimiento);
            tpIngreso.Controls.Add(cmbProveedor);
            tpIngreso.Controls.Add(nudPrecio);
            tpIngreso.Controls.Add(nudCantidadIngreso);
            tpIngreso.Controls.Add(cmbProductosIngreso);
            tpIngreso.Location = new Point(4, 29);
            tpIngreso.Name = "tpIngreso";
            tpIngreso.Padding = new Padding(3);
            tpIngreso.Size = new Size(375, 306);
            tpIngreso.TabIndex = 0;
            tpIngreso.Text = "Ingreso";
            tpIngreso.UseVisualStyleBackColor = true;
            // 
            // btnRegistrarIngreso
            // 
            btnRegistrarIngreso.Location = new Point(110, 254);
            btnRegistrarIngreso.Name = "btnRegistrarIngreso";
            btnRegistrarIngreso.Size = new Size(162, 43);
            btnRegistrarIngreso.TabIndex = 17;
            btnRegistrarIngreso.Text = "Registrar Ingreso";
            btnRegistrarIngreso.UseVisualStyleBackColor = true;
            btnRegistrarIngreso.Click += btnRegistrarIngreso_Click;
            // 
            // chkVencimiento
            // 
            chkVencimiento.AutoSize = true;
            chkVencimiento.Location = new Point(19, 181);
            chkVencimiento.Name = "chkVencimiento";
            chkVencimiento.Size = new Size(116, 24);
            chkVencimiento.TabIndex = 10;
            chkVencimiento.Text = "Vencimiento:";
            chkVencimiento.UseVisualStyleBackColor = true;
            // 
            // lblProveedor
            // 
            lblProveedor.AutoSize = true;
            lblProveedor.Location = new Point(20, 145);
            lblProveedor.Name = "lblProveedor";
            lblProveedor.Size = new Size(80, 20);
            lblProveedor.TabIndex = 9;
            lblProveedor.Text = "Proveedor:";
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Location = new Point(19, 103);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(110, 20);
            lblPrecio.TabIndex = 8;
            lblPrecio.Text = "Precio Compra:";
            // 
            // lblCantidadIngreso
            // 
            lblCantidadIngreso.AutoSize = true;
            lblCantidadIngreso.Location = new Point(20, 61);
            lblCantidadIngreso.Name = "lblCantidadIngreso";
            lblCantidadIngreso.Size = new Size(72, 20);
            lblCantidadIngreso.TabIndex = 7;
            lblCantidadIngreso.Text = "Cantidad:";
            // 
            // lblProductoIngreso
            // 
            lblProductoIngreso.AutoSize = true;
            lblProductoIngreso.Location = new Point(19, 19);
            lblProductoIngreso.Name = "lblProductoIngreso";
            lblProductoIngreso.Size = new Size(72, 20);
            lblProductoIngreso.TabIndex = 6;
            lblProductoIngreso.Text = "Producto:";
            // 
            // dtpVencimiento
            // 
            dtpVencimiento.Location = new Point(19, 211);
            dtpVencimiento.Name = "dtpVencimiento";
            dtpVencimiento.Size = new Size(333, 27);
            dtpVencimiento.TabIndex = 4;
            // 
            // cmbProveedor
            // 
            cmbProveedor.FormattingEnabled = true;
            cmbProveedor.Location = new Point(149, 142);
            cmbProveedor.Name = "cmbProveedor";
            cmbProveedor.Size = new Size(203, 28);
            cmbProveedor.TabIndex = 3;
            // 
            // nudPrecio
            // 
            nudPrecio.Location = new Point(149, 101);
            nudPrecio.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            nudPrecio.Name = "nudPrecio";
            nudPrecio.Size = new Size(203, 27);
            nudPrecio.TabIndex = 2;
            // 
            // nudCantidadIngreso
            // 
            nudCantidadIngreso.Location = new Point(149, 59);
            nudCantidadIngreso.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            nudCantidadIngreso.Name = "nudCantidadIngreso";
            nudCantidadIngreso.Size = new Size(203, 27);
            nudCantidadIngreso.TabIndex = 1;
            // 
            // cmbProductosIngreso
            // 
            cmbProductosIngreso.FormattingEnabled = true;
            cmbProductosIngreso.Location = new Point(149, 16);
            cmbProductosIngreso.Name = "cmbProductosIngreso";
            cmbProductosIngreso.Size = new Size(203, 28);
            cmbProductosIngreso.TabIndex = 0;
            // 
            // tpEgreso
            // 
            tpEgreso.Controls.Add(btnRegistrarEgreso);
            tpEgreso.Controls.Add(cmbProductosEgreso);
            tpEgreso.Controls.Add(nudCantidadEgreso);
            tpEgreso.Controls.Add(lblTipoEgreso);
            tpEgreso.Controls.Add(lblCantidadEgreso);
            tpEgreso.Controls.Add(cmbTipoEgreso);
            tpEgreso.Controls.Add(lblProductosEgreso);
            tpEgreso.Location = new Point(4, 29);
            tpEgreso.Name = "tpEgreso";
            tpEgreso.Padding = new Padding(3);
            tpEgreso.Size = new Size(375, 306);
            tpEgreso.TabIndex = 1;
            tpEgreso.Text = "Egreso";
            tpEgreso.UseVisualStyleBackColor = true;
            // 
            // btnRegistrarEgreso
            // 
            btnRegistrarEgreso.Location = new Point(110, 157);
            btnRegistrarEgreso.Name = "btnRegistrarEgreso";
            btnRegistrarEgreso.Size = new Size(162, 43);
            btnRegistrarEgreso.TabIndex = 16;
            btnRegistrarEgreso.Text = "Registrar Egreso";
            btnRegistrarEgreso.UseVisualStyleBackColor = true;
            btnRegistrarEgreso.Click += btnRegistrarEgreso_Click;
            // 
            // cmbProductosEgreso
            // 
            cmbProductosEgreso.FormattingEnabled = true;
            cmbProductosEgreso.Location = new Point(149, 23);
            cmbProductosEgreso.Name = "cmbProductosEgreso";
            cmbProductosEgreso.Size = new Size(203, 28);
            cmbProductosEgreso.TabIndex = 11;
            // 
            // nudCantidadEgreso
            // 
            nudCantidadEgreso.Location = new Point(149, 66);
            nudCantidadEgreso.Name = "nudCantidadEgreso";
            nudCantidadEgreso.Size = new Size(203, 27);
            nudCantidadEgreso.TabIndex = 12;
            // 
            // lblTipoEgreso
            // 
            lblTipoEgreso.AutoSize = true;
            lblTipoEgreso.Location = new Point(19, 110);
            lblTipoEgreso.Name = "lblTipoEgreso";
            lblTipoEgreso.Size = new Size(91, 20);
            lblTipoEgreso.TabIndex = 19;
            lblTipoEgreso.Text = "Tipo Egreso:";
            // 
            // lblCantidadEgreso
            // 
            lblCantidadEgreso.AutoSize = true;
            lblCantidadEgreso.Location = new Point(20, 68);
            lblCantidadEgreso.Name = "lblCantidadEgreso";
            lblCantidadEgreso.Size = new Size(72, 20);
            lblCantidadEgreso.TabIndex = 18;
            lblCantidadEgreso.Text = "Cantidad:";
            // 
            // cmbTipoEgreso
            // 
            cmbTipoEgreso.FormattingEnabled = true;
            cmbTipoEgreso.Location = new Point(149, 107);
            cmbTipoEgreso.Name = "cmbTipoEgreso";
            cmbTipoEgreso.Size = new Size(203, 28);
            cmbTipoEgreso.TabIndex = 14;
            // 
            // lblProductosEgreso
            // 
            lblProductosEgreso.AutoSize = true;
            lblProductosEgreso.Location = new Point(19, 26);
            lblProductosEgreso.Name = "lblProductosEgreso";
            lblProductosEgreso.Size = new Size(72, 20);
            lblProductosEgreso.TabIndex = 17;
            lblProductosEgreso.Text = "Producto:";
            // 
            // dgvMovimientos
            // 
            dgvMovimientos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMovimientos.Location = new Point(401, 41);
            dgvMovimientos.Name = "dgvMovimientos";
            dgvMovimientos.RowHeadersWidth = 51;
            dgvMovimientos.Size = new Size(626, 540);
            dgvMovimientos.TabIndex = 1;
            // 
            // lblMovimientos
            // 
            lblMovimientos.AutoSize = true;
            lblMovimientos.Location = new Point(401, 18);
            lblMovimientos.Name = "lblMovimientos";
            lblMovimientos.Size = new Size(179, 20);
            lblMovimientos.TabIndex = 11;
            lblMovimientos.Text = "Historial de Movimientos:";
            // 
            // cmbFiltroProducto
            // 
            cmbFiltroProducto.FormattingEnabled = true;
            cmbFiltroProducto.Location = new Point(17, 53);
            cmbFiltroProducto.Name = "cmbFiltroProducto";
            cmbFiltroProducto.Size = new Size(162, 28);
            cmbFiltroProducto.TabIndex = 12;
            // 
            // cmbFiltroTipo
            // 
            cmbFiltroTipo.FormattingEnabled = true;
            cmbFiltroTipo.Location = new Point(194, 53);
            cmbFiltroTipo.Name = "cmbFiltroTipo";
            cmbFiltroTipo.Size = new Size(162, 28);
            cmbFiltroTipo.TabIndex = 13;
            // 
            // gbFiltros
            // 
            gbFiltros.Controls.Add(btnLimpiarFiltros);
            gbFiltros.Controls.Add(chkHasta);
            gbFiltros.Controls.Add(chkDesde);
            gbFiltros.Controls.Add(lblFiltroTipo);
            gbFiltros.Controls.Add(lblFiltroProducto);
            gbFiltros.Controls.Add(btnFiltrar);
            gbFiltros.Controls.Add(dtpHasta);
            gbFiltros.Controls.Add(dtpDesde);
            gbFiltros.Controls.Add(cmbFiltroProducto);
            gbFiltros.Controls.Add(cmbFiltroTipo);
            gbFiltros.Location = new Point(16, 353);
            gbFiltros.Name = "gbFiltros";
            gbFiltros.Size = new Size(375, 228);
            gbFiltros.TabIndex = 14;
            gbFiltros.TabStop = false;
            gbFiltros.Text = "Filtro de Movimientos";
            // 
            // btnLimpiarFiltros
            // 
            btnLimpiarFiltros.Location = new Point(59, 183);
            btnLimpiarFiltros.Name = "btnLimpiarFiltros";
            btnLimpiarFiltros.Size = new Size(120, 39);
            btnLimpiarFiltros.TabIndex = 21;
            btnLimpiarFiltros.Text = "Limpiar";
            btnLimpiarFiltros.UseVisualStyleBackColor = true;
            btnLimpiarFiltros.Click += btnLimpiarFiltros_Click;
            // 
            // chkHasta
            // 
            chkHasta.AutoSize = true;
            chkHasta.Location = new Point(17, 144);
            chkHasta.Name = "chkHasta";
            chkHasta.Size = new Size(72, 24);
            chkHasta.TabIndex = 20;
            chkHasta.Text = "Hasta:";
            chkHasta.UseVisualStyleBackColor = true;
            // 
            // chkDesde
            // 
            chkDesde.AutoSize = true;
            chkDesde.Location = new Point(17, 101);
            chkDesde.Name = "chkDesde";
            chkDesde.Size = new Size(76, 24);
            chkDesde.TabIndex = 19;
            chkDesde.Text = "Desde:";
            chkDesde.UseVisualStyleBackColor = true;
            // 
            // lblFiltroTipo
            // 
            lblFiltroTipo.AutoSize = true;
            lblFiltroTipo.Location = new Point(194, 30);
            lblFiltroTipo.Name = "lblFiltroTipo";
            lblFiltroTipo.Size = new Size(42, 20);
            lblFiltroTipo.TabIndex = 18;
            lblFiltroTipo.Text = "Tipo:";
            // 
            // lblFiltroProducto
            // 
            lblFiltroProducto.AutoSize = true;
            lblFiltroProducto.Location = new Point(17, 30);
            lblFiltroProducto.Name = "lblFiltroProducto";
            lblFiltroProducto.Size = new Size(72, 20);
            lblFiltroProducto.TabIndex = 17;
            lblFiltroProducto.Text = "Producto:";
            // 
            // btnFiltrar
            // 
            btnFiltrar.Location = new Point(194, 183);
            btnFiltrar.Name = "btnFiltrar";
            btnFiltrar.Size = new Size(120, 39);
            btnFiltrar.TabIndex = 16;
            btnFiltrar.Text = "Filtrar";
            btnFiltrar.UseVisualStyleBackColor = true;
            btnFiltrar.Click += btnFiltrar_Click;
            // 
            // dtpHasta
            // 
            dtpHasta.Location = new Point(99, 142);
            dtpHasta.Name = "dtpHasta";
            dtpHasta.Size = new Size(257, 27);
            dtpHasta.TabIndex = 15;
            // 
            // dtpDesde
            // 
            dtpDesde.Location = new Point(99, 99);
            dtpDesde.Name = "dtpDesde";
            dtpDesde.Size = new Size(257, 27);
            dtpDesde.TabIndex = 14;
            // 
            // FormMovimientos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1039, 593);
            Controls.Add(gbFiltros);
            Controls.Add(lblMovimientos);
            Controls.Add(dgvMovimientos);
            Controls.Add(tabMovimientos);
            Name = "FormMovimientos";
            Text = "Menú Movimientos";
            tabMovimientos.ResumeLayout(false);
            tpIngreso.ResumeLayout(false);
            tpIngreso.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudPrecio).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudCantidadIngreso).EndInit();
            tpEgreso.ResumeLayout(false);
            tpEgreso.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudCantidadEgreso).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvMovimientos).EndInit();
            gbFiltros.ResumeLayout(false);
            gbFiltros.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TabControl tabMovimientos;
        private TabPage tpIngreso;
        private TabPage tpEgreso;
        private Label lblVencimiento;
        private Label lblProveedor;
        private Label lblPrecio;
        private Label lblCantidadIngreso;
        private Label lblProductoIngreso;
        private DateTimePicker dtpVencimiento;
        private ComboBox cmbProveedor;
        private NumericUpDown nudPrecio;
        private NumericUpDown nudCantidadIngreso;
        private ComboBox cmbProductosIngreso;
        private CheckBox chkVencimiento;
        private DataGridView dgvMovimientos;
        private Button btnRegistrarEgreso;
        private ComboBox cmbProductosEgreso;
        private NumericUpDown nudCantidadEgreso;
        private Label lblTipoEgreso;
        private Label lblCantidadEgreso;
        private ComboBox cmbTipoEgreso;
        private Label lblProductosEgreso;
        private Label lblMovimientos;
        private Button btnRegistrarIngreso;
        private ComboBox cmbFiltroProducto;
        private ComboBox cmbFiltroTipo;
        private GroupBox gbFiltros;
        private DateTimePicker dtpHasta;
        private DateTimePicker dtpDesde;
        private CheckBox chkHasta;
        private CheckBox chkDesde;
        private Label lblFiltroTipo;
        private Label lblFiltroProducto;
        private Button btnFiltrar;
        private Button btnLimpiarFiltros;
    }
}