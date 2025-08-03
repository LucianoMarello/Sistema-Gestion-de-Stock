using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Gestion_de_Stock.Entidades
{
    public class Lote
    {
        public int Cantidad { get; set; }
        public DateTime FechaVencimiento { get; set; }
        public double PrecioCompra {  get; set; }

        public Lote(int cant, double precio, DateTime vencimiento)
        {
            Cantidad = cant;
            FechaVencimiento = vencimiento;
            PrecioCompra = precio;
        }

        public bool EstaVencido => FechaVencimiento < DateTime.Today;

        public bool EstaPorVencer => FechaVencimiento <= DateTime.Today.AddDays(7);
    }
}
