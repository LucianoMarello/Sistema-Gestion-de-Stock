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
        public int IdRubro { get; set; } //asi o hacerlo de tipo rubro?
        public bool Disponible { get; set; }
        public List<int> ListaLotes { get; set; }

        public Producto(int id, string nom, string desc, int cant, double precio, int rubro, bool disponible, List<int> listaIds)
        {
            IdProducto = id;
            Nombre = nom;
            Descripcion = desc;
            Stock = cant;
            PrecioVenta = precio * 1.5;
            IdRubro = rubro;
            Disponible = disponible;
            ListaLotes = listaIds;
        }

        public void Vencimiento() //Donde lo muestro? / donde lo llamo?
        {
            foreach(Lote lote in ListaLotes)
            {
                if (lote.EstaVencido())
                {
                    ListaLotes.Remove(lote);

                }
            }
        }
    }
}
