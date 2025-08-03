using Sistema_Gestion_de_Stock.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Gestion_de_Stock.Entidades
{
    public class Producto
    {
        public int IdProducto { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public int Stock { get; set; }
        public double PrecioVenta { get; set; }
        public int IdRubro { get; set; }
        public bool Disponible { get; set; }
        public List<int> ListaLotes { get; set; }

        public Producto(int id, string nom, string descripcion, int stock, double precioUnitario, int idRubro)
        {
            IdProducto = id;
            Nombre = nom;
            Descripcion = descripcion;
            Stock = stock;
            PrecioVenta = precioUnitario;
            IdRubro = idRubro;
            Disponible = true;
            ListaLotes = new List<int>();
        }

        //FALTAN METODOS SOBRE EL VENCIMIENTO

        public void CalcularPrecioVenta(double precioCompra)
        {
            PrecioVenta = 1.5 * precioCompra;
        }

        public int CalcularStockTotal(RepositorioLotes repoLotes)
        {
            return ListaLotes
                .Select(id => repoLotes.BuscarPorId(id))
                .Where(l => l != null)
                .Sum(l => l.Cantidad);
        }
    }
}
