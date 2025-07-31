using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Gestion_de_Stock.Entidades
{
    public class Ingreso : Movimiento
    {
        public int IdProveedor { get; set; }
        public DateTime FechaVencimiento { get; set; }
        public double PrecioCompra {  get; set; }

        public Ingreso(int idMovimiento, int idProducto, int cantidad, int idProveedor, DateTime fechaVencimiento, double precioCompra)
            : base(idMovimiento, idProducto, cantidad)
        {
            IdProveedor = idProveedor;
            FechaVencimiento = fechaVencimiento;
            PrecioCompra = precioCompra;
        }

        public override void AplicarMovimiento()
        {
            Lote nuevoLote = new Lote(IdProducto, Cantidad, FechaVencimiento, PrecioCompra);
            //hacer que busque el producto correspondiente dentro del repositorio y lo guarda en la lista
        }
    }
}
