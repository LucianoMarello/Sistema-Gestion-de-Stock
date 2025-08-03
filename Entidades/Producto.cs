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
        public double PrecioVenta { get; set; }
        public int IdRubro { get; set; }
        public bool Disponible { get; set; }
        public List<Lote> ListaLotes { get; set; }

        public Producto(int id, string nom, string descripcion, double precioUnitario, int idRubro, bool disponible)
        {
            IdProducto = id;
            Nombre = nom;
            Descripcion = descripcion;
            PrecioVenta = precioUnitario * 1.5;
            IdRubro = idRubro;
            Disponible = disponible;
            ListaLotes = new List<Lote>();
        }

        //FALTAN METODOS SOBRE EL VENCIMIENTO

        public int CalcularStockTotal()
        {
            return ListaLotes.Sum(l => l.Cantidad);
        }
    }
}
