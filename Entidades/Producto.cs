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
            PrecioVenta = precioUnitario;
            IdRubro = idRubro;
            Disponible = disponible;
            ListaLotes = new List<Lote>();
        }

        public List<Lote> LotesPorVencer()
        {
            int dias = 7;
            DateTime hoy = DateTime.Today;
            DateTime limite = hoy.AddDays(dias);

            return ListaLotes
                .Where(l => l.FechaVencimiento > hoy && l.FechaVencimiento <= limite)
                .ToList();
        }

        public void EliminarLotesVencidos()
        {
            DateTime hoy = DateTime.Today;
            ListaLotes.RemoveAll(l => l.FechaVencimiento != new DateTime(1900, 1, 1) && l.FechaVencimiento < hoy);
            ActualizarPrecioVentaDesdeLotes();
        }

        public void ActualizarPrecioVentaDesdeLotes()
        {
            if (ListaLotes.Any())
            {
                double precioMayor = ListaLotes.Max(l => l.PrecioCompra);
                PrecioVenta = precioMayor * 1.5;
            }
        }

        public int CalcularStockTotal()
        {
            return ListaLotes.Sum(l => l.Cantidad);
        }
    }
}
