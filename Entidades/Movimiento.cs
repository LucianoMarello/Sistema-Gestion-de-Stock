using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Gestion_de_Stock.Entidades
{
    public abstract class Movimiento
    {
        public int IdMovimiento { get; set; }
        public int IdProducto { get; set; }
        public DateTime Fecha { get; set; }
        public int Cantidad { get; set; }

        public Movimiento(int idMovimiento, int idProducto, DateTime fecha, int cantidad)
        {
            this.IdMovimiento = idMovimiento;
            this.IdProducto = idProducto;
            Fecha = fecha;
            this.Cantidad = cantidad;
        }

        public abstract void AplicarMovimiento(Producto producto);
    }
}
