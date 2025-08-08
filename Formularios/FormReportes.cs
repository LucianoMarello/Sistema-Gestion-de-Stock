using Sistema_Gestion_de_Stock.Entidades;
using Sistema_Gestion_de_Stock.Repositorios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Gestion_de_Stock.Formularios
{
    public partial class FormReportes : Form
    {
        private RepositorioProducto repoProductos;
        private RepositorioRubro repoRubros;
        private RepositorioMovimientos repoMovimientos;
        private RepositorioProveedor repoProveedores;

        public FormReportes()
        {
            InitializeComponent();
            repoProductos = new RepositorioProducto();
            repoRubros = new RepositorioRubro();
            repoMovimientos = new RepositorioMovimientos();
            repoProveedores = new RepositorioProveedor();

            CargarCmb();
        }

        private void CargarCmb()
        {
            var productos = repoProductos.Listar();

            cmbProductos.DataSource = new List<Producto>(productos);
            cmbProductos.DisplayMember = "Nombre";
            cmbProductos.ValueMember = "IdProducto";
            cmbProductos.SelectedIndex = -1;

            var proveedores = repoProveedores.Listar();

            cmbProveedores.DataSource = new List<Proveedor>(proveedores);
            cmbProveedores.DisplayMember = "Nombre";
            cmbProveedores.ValueMember = "IdProveedor";
            cmbProveedores.SelectedIndex = -1;
        }

        private void btnStockProducto_Click(object sender, EventArgs e)
        {
            dgvReportes.Rows.Clear();
            dgvReportes.Columns.Clear();

            dgvReportes.Columns.Add("IdProducto", "ID");
            dgvReportes.Columns.Add("Producto", "Producto");
            dgvReportes.Columns.Add("Stock", "Stock");
            dgvReportes.Columns[1].Width = 200;

            CargarStockProductos();
            GenerarStockProductos();
        }

        private void CargarStockProductos()
        {
            var productos = repoProductos.Listar();

            foreach (var p in productos)
            {
                dgvReportes.Rows.Add(p.IdProducto, p.Nombre, p.CalcularStockTotal());
            }
        }

        private void GenerarStockProductos()
        {
            var productos = repoProductos.Listar();
            string rutaArchivo = Path.Combine(Application.StartupPath, "Reportes", "stock-por-productos.txt");
            Directory.CreateDirectory(Path.GetDirectoryName(rutaArchivo));

            using (StreamWriter sw = new StreamWriter(rutaArchivo, false))
            {
                sw.WriteLine("ID\tProducto\t\tStock");
                sw.WriteLine("---------------------------------------");

                foreach (var p in productos)
                {
                    sw.WriteLine($"{p.IdProducto}\t{p.Nombre}\t\t{p.CalcularStockTotal()}");
                }
            }

            MessageBox.Show("Reporte generado exitosamente");
        }

        private void btnStockRubro_Click(object sender, EventArgs e)
        {
            dgvReportes.Rows.Clear();
            dgvReportes.Columns.Clear();

            dgvReportes.Columns.Add("IdRubro", "Rubro");
            dgvReportes.Columns.Add("Rubro", "Rubro");
            dgvReportes.Columns.Add("Stock", "Stock");

            CargarStockRubros();
            GenerarStockRubros();
        }

        private void CargarStockRubros()
        {
            var rubros = repoRubros.Listar();

            foreach (var r in rubros)
            {
                var productosDelRubro = repoProductos.Listar().Where(p => p.IdRubro == r.IdRubro).ToList();
                int suma = productosDelRubro.Sum(p => p.CalcularStockTotal());

                dgvReportes.Rows.Add(r.IdRubro, r.Categoria, suma);
            }
        }

        private void GenerarStockRubros()
        {
            var rubros = repoRubros.Listar();
            string rutaArchivo = Path.Combine(Application.StartupPath, "Reportes", "stock-por-rubros.txt");
            Directory.CreateDirectory(Path.GetDirectoryName(rutaArchivo));

            using (StreamWriter sw = new StreamWriter(rutaArchivo, false))
            {
                sw.WriteLine("ID\tProducto\t\tStock");
                sw.WriteLine("---------------------------------------");

                foreach (var r in rubros)
                {
                    var productosDelRubro = repoProductos.Listar().Where(p => p.IdRubro == r.IdRubro).ToList();
                    int suma = productosDelRubro.Sum(p => p.CalcularStockTotal());

                    sw.WriteLine($"{r.IdRubro}\t{r.Categoria}\t\t{suma}");
                }
            }

            MessageBox.Show("Reporte generado exitosamente");
        }

        private void btnMovProveedores_Click(object sender, EventArgs e)
        {
            dgvReportes.Rows.Clear();
            dgvReportes.Columns.Clear();

            dgvReportes.Columns.Add("IdMovimiento", "ID");
            dgvReportes.Columns.Add("Producto", "Producto");
            dgvReportes.Columns.Add("Cantidad", "Cantidad");
            dgvReportes.Columns.Add("Fecha", "Fecha");
            dgvReportes.Columns.Add("Precio", "Precio");

            if (cmbProveedores.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un proveedor.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            CargarMovProveedores();
        }

        private void CargarMovProveedores()
        {
            int id = (int)cmbProveedores.SelectedValue;

            var movimientos = repoMovimientos.Listar()
                .OfType<Ingreso>()
                .Where(m => m.IdProveedor == id)
                .OrderBy(m => m.Fecha)
                .ToList();

            foreach (var mov in movimientos)
            {
                var prod = repoProductos.Listar().FirstOrDefault(p => p.IdProducto == mov.IdProducto);

                dgvReportes.Rows.Add(mov.IdMovimiento, prod.Nombre, mov.Cantidad, mov.Fecha.ToString("dd/MM/yyyy"), mov.PrecioCompra);
            }

            GenerarMovProveedores(movimientos, id);
        }

        private void GenerarMovProveedores(List<Ingreso> movimientos, int id)
        {
            var proveedor = repoProveedores.BuscarPorId(id);
            string rutaArchivo = Path.Combine(Application.StartupPath, "Reportes", $"movimientos-{proveedor.Nombre}.txt");
            Directory.CreateDirectory(Path.GetDirectoryName(rutaArchivo));

            using (StreamWriter sw = new StreamWriter(rutaArchivo, false))
            {
                sw.WriteLine($"Movimientos del proveedor: {proveedor.Nombre}");
                sw.WriteLine("---------------------------------------");
                sw.WriteLine("Fecha\t\tProducto\t\tCantidad\t\tPrecio");
                sw.WriteLine("---------------------------------------");

                foreach (var mov in movimientos)
                {
                    var prod = repoProductos.Listar().FirstOrDefault(p => p.IdProducto == mov.IdProducto);

                    sw.WriteLine($"{mov.Fecha:dd/MM/yyyy}\t{prod.Nombre}\t\t{mov.Cantidad}\t\t{mov.PrecioCompra}");
                }
            }

            MessageBox.Show($"Reporte generado exitosamente");
        }

        private void btnBajoStock_Click(object sender, EventArgs e)
        {
            dgvReportes.Rows.Clear();
            dgvReportes.Columns.Clear();

            dgvReportes.Columns.Add("IdProducto", "ID");
            dgvReportes.Columns.Add("Producto", "Producto");
            dgvReportes.Columns.Add("Cantidad", "Cantidad");
            dgvReportes.Columns.Add("Precio", "Precio");

            if (nudBajoStock.Value == 0)
            {
                MessageBox.Show("Ingrese una cantidad valida de stock.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            CargarBajoStock();
        }

        private void CargarBajoStock()
        {
            int umbral = (int)nudBajoStock.Value;

            var productosBajoStock = repoProductos.Listar()
                .Where(p => p.CalcularStockTotal() < umbral)
                .ToList();

            foreach (var p in productosBajoStock)
            {
                dgvReportes.Rows.Add(p.IdProducto, p.Nombre, p.CalcularStockTotal(), p.PrecioVenta);
            }

            GenerarBajoStock(productosBajoStock, umbral);
        }

        private void GenerarBajoStock(List<Producto> productos, int umbral)
        {
            string rutaArchivo = Path.Combine(Application.StartupPath, "Reportes", "productos-bajo-stock.txt");
            Directory.CreateDirectory(Path.GetDirectoryName(rutaArchivo));

            using (StreamWriter sw = new StreamWriter(rutaArchivo, false))
            {
                sw.WriteLine($"Productos con stock menor a {umbral}");
                sw.WriteLine("---------------------------------------");
                sw.WriteLine("ID\t\tProducto\t\tStock\t\tPrecio");
                sw.WriteLine("---------------------------------------");

                foreach (var p in productos)
                {
                    sw.WriteLine($"{p.IdProducto}\t\t{p.Nombre}\t\t{p.CalcularStockTotal()}\t\t{p.PrecioVenta}");
                }
            }

            MessageBox.Show($"Reporte generado exitosamente");
        }

        private void btnHistorialProductos_Click(object sender, EventArgs e)
        {
            dgvReportes.Rows.Clear();
            dgvReportes.Columns.Clear();

            dgvReportes.Columns.Add("IdMovimiento", "ID");
            dgvReportes.Columns.Add("Tipo", "Tipo");
            dgvReportes.Columns.Add("Producto", "Producto");
            dgvReportes.Columns.Add("Cantidad", "Cantidad");
            dgvReportes.Columns.Add("Fecha", "Fecha");
            dgvReportes.Columns.Add("Precio", "Precio");

            if (cmbProductos.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un producto.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            CargarHistorialProductos();
        }

        private void CargarHistorialProductos()
        {
            int id = (int)cmbProductos.SelectedValue;
            var producto = repoProductos.BuscarPorId(id);

            var movimientos = repoMovimientos.Listar()
                .Where(m => m.IdProducto == id)
                .OrderBy(m => m.Fecha)
                .ToList();

            foreach (var m in movimientos)
            {
                var precio = m is Ingreso ingreso
                    ? ingreso.PrecioCompra.ToString()
                    : producto.PrecioVenta.ToString();

                dgvReportes.Rows.Add(
                    m.IdMovimiento,
                    m.GetType().Name,
                    producto.Nombre,
                    m.Cantidad,
                    m.Fecha.ToString("dd/MM/yyyy"),
                    precio
                );
            }

            GenerarHistorialProductos(movimientos, producto);
        }

        private void GenerarHistorialProductos(List<Movimiento> movimientos, Producto prod)
        {
            string rutaArchivo = Path.Combine(Application.StartupPath, "Reportes", $"historial-movimientos-{prod.Nombre}.txt");
            Directory.CreateDirectory(Path.GetDirectoryName(rutaArchivo));

            using (StreamWriter sw = new StreamWriter(rutaArchivo, false))
            {
                sw.WriteLine($"Historial de movimientos del producto: {prod.Nombre}");
                sw.WriteLine("---------------------------------------");
                sw.WriteLine("Fecha\t\tTipo\t\tCantidad\t\tPrecio");
                sw.WriteLine("---------------------------------------");

                foreach (var mov in movimientos)
                {
                    var precio = mov is Ingreso ingreso
                    ? ingreso.PrecioCompra.ToString()
                    : prod.PrecioVenta.ToString();

                    sw.WriteLine($"{mov.Fecha:dd/MM/yyyy}\t{mov.GetType().Name}\t\t{mov.Cantidad}\t\t{precio}");
                }
            }
        }
    }
}
