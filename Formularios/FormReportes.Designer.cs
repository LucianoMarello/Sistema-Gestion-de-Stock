namespace Sistema_Gestion_de_Stock.Formularios
{
    partial class FormReportes
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
            btnStockProducto = new Button();
            dgvReportes = new DataGridView();
            btnStockRubro = new Button();
            btnMovProveedores = new Button();
            btnBajoStock = new Button();
            btnHistorialProductos = new Button();
            gbReporte = new GroupBox();
            cmbProveedores = new ComboBox();
            cmbProductos = new ComboBox();
            nudBajoStock = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)dgvReportes).BeginInit();
            gbReporte.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudBajoStock).BeginInit();
            SuspendLayout();
            // 
            // btnStockProducto
            // 
            btnStockProducto.Location = new Point(38, 39);
            btnStockProducto.Name = "btnStockProducto";
            btnStockProducto.Size = new Size(143, 57);
            btnStockProducto.TabIndex = 0;
            btnStockProducto.Text = "Stock Actual por Producto";
            btnStockProducto.UseVisualStyleBackColor = true;
            btnStockProducto.Click += btnStockProducto_Click;
            // 
            // dgvReportes
            // 
            dgvReportes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReportes.Location = new Point(245, 12);
            dgvReportes.Name = "dgvReportes";
            dgvReportes.RowHeadersWidth = 51;
            dgvReportes.Size = new Size(703, 528);
            dgvReportes.TabIndex = 1;
            // 
            // btnStockRubro
            // 
            btnStockRubro.Location = new Point(38, 114);
            btnStockRubro.Name = "btnStockRubro";
            btnStockRubro.Size = new Size(143, 57);
            btnStockRubro.TabIndex = 2;
            btnStockRubro.Text = "Stock por Rubro";
            btnStockRubro.UseVisualStyleBackColor = true;
            btnStockRubro.Click += btnStockRubro_Click;
            // 
            // btnMovProveedores
            // 
            btnMovProveedores.Location = new Point(38, 189);
            btnMovProveedores.Name = "btnMovProveedores";
            btnMovProveedores.Size = new Size(143, 57);
            btnMovProveedores.TabIndex = 3;
            btnMovProveedores.Text = "Movimientos por Proveedor";
            btnMovProveedores.UseVisualStyleBackColor = true;
            btnMovProveedores.Click += btnMovProveedores_Click;
            // 
            // btnBajoStock
            // 
            btnBajoStock.Location = new Point(38, 303);
            btnBajoStock.Name = "btnBajoStock";
            btnBajoStock.Size = new Size(143, 57);
            btnBajoStock.TabIndex = 4;
            btnBajoStock.Text = "Productos con Bajo Stock";
            btnBajoStock.UseVisualStyleBackColor = true;
            btnBajoStock.Click += btnBajoStock_Click;
            // 
            // btnHistorialProductos
            // 
            btnHistorialProductos.Location = new Point(38, 416);
            btnHistorialProductos.Name = "btnHistorialProductos";
            btnHistorialProductos.Size = new Size(143, 57);
            btnHistorialProductos.TabIndex = 5;
            btnHistorialProductos.Text = "Historial de Movimientos de:";
            btnHistorialProductos.UseVisualStyleBackColor = true;
            btnHistorialProductos.Click += btnHistorialProductos_Click;
            // 
            // gbReporte
            // 
            gbReporte.Controls.Add(cmbProveedores);
            gbReporte.Controls.Add(cmbProductos);
            gbReporte.Controls.Add(nudBajoStock);
            gbReporte.Controls.Add(btnHistorialProductos);
            gbReporte.Controls.Add(btnStockProducto);
            gbReporte.Controls.Add(btnBajoStock);
            gbReporte.Controls.Add(btnStockRubro);
            gbReporte.Controls.Add(btnMovProveedores);
            gbReporte.Location = new Point(12, 12);
            gbReporte.Name = "gbReporte";
            gbReporte.Size = new Size(217, 528);
            gbReporte.TabIndex = 6;
            gbReporte.TabStop = false;
            gbReporte.Text = "Generar Reporte";
            // 
            // cmbProveedores
            // 
            cmbProveedores.FormattingEnabled = true;
            cmbProveedores.Location = new Point(38, 252);
            cmbProveedores.Name = "cmbProveedores";
            cmbProveedores.Size = new Size(143, 28);
            cmbProveedores.TabIndex = 8;
            // 
            // cmbProductos
            // 
            cmbProductos.FormattingEnabled = true;
            cmbProductos.Location = new Point(38, 479);
            cmbProductos.Name = "cmbProductos";
            cmbProductos.Size = new Size(143, 28);
            cmbProductos.TabIndex = 7;
            // 
            // nudBajoStock
            // 
            nudBajoStock.Location = new Point(38, 366);
            nudBajoStock.Name = "nudBajoStock";
            nudBajoStock.Size = new Size(143, 27);
            nudBajoStock.TabIndex = 6;
            // 
            // FormReportes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(960, 552);
            Controls.Add(dgvReportes);
            Controls.Add(gbReporte);
            Name = "FormReportes";
            Text = "Menú Reportes";
            ((System.ComponentModel.ISupportInitialize)dgvReportes).EndInit();
            gbReporte.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)nudBajoStock).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnStockProducto;
        private DataGridView dgvReportes;
        private Button btnStockRubro;
        private Button btnMovProveedores;
        private Button btnBajoStock;
        private Button btnHistorialProductos;
        private GroupBox gbReporte;
        private ComboBox cmbProductos;
        private NumericUpDown nudBajoStock;
        private ComboBox cmbProveedores;
    }
}