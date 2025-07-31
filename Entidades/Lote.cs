using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Gestion_de_Stock.Entidades
{
    public class Lote
    {
        public int IdProducto { get; set; }
        public int Cantidad { get; set; }
        public DateTime FechaVencimiento { get; set; }
        public double PrecioCompra {  get; set; }

        public Lote(int id, int cant, DateTime vencimiento, double precio)
        {
            IdProducto = id;
            Cantidad = cant;
            FechaVencimiento = vencimiento;
            PrecioCompra = precio;
        }

        public bool EstaVencido()
        {
            if (FechaVencimiento < DateTime.Now)
            {
                return true;
            }
            return false;
        }
    }
}
