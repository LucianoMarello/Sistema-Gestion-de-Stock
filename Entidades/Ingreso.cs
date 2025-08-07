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
        public double PrecioCompra {  get; set; }
        public DateTime FechaVencimiento { get; set; }

        public Ingreso(int idMovimiento, int idProducto, DateTime fecha, int cantidad, int idProveedor, DateTime fechaVencimiento, double precioCompra)
            : base(idMovimiento, idProducto, fecha, cantidad)
        {
            IdProveedor = idProveedor;
            FechaVencimiento = fechaVencimiento;
            PrecioCompra = precioCompra;
        }

        public override void AplicarMovimiento(Producto producto)
        {
            producto.ListaLotes.Add(new Lote(Cantidad,PrecioCompra,FechaVencimiento));
            producto.ActualizarPrecioVentaDesdeLotes();
        }
    }
}
