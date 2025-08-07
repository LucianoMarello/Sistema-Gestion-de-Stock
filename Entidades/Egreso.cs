using Sistema_Gestion_de_Stock.Utilidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Gestion_de_Stock.Entidades
{
    public class Egreso : Movimiento
    {
        public TipoEgreso Tipo { get; set; }

        public Egreso(int idMovimiento, int idProducto, DateTime fecha, int cantidad, TipoEgreso tipo)
            : base(idMovimiento, idProducto, fecha, cantidad)
        {
            Tipo = tipo;
        }

        public override void AplicarMovimiento(Producto producto)
        {
            int restante = Cantidad;

            var lotesOrdenados = producto.ListaLotes
                .OrderBy(l => l.FechaVencimiento != new DateTime(1900, 1, 1)) // los sin vencimiento van últimos
                .ThenBy(l => l.FechaVencimiento)
                .ToList();

            foreach (var lote in lotesOrdenados)
            {
                int aDescontar = Math.Min(lote.Cantidad, restante);
                lote.Cantidad -= aDescontar;
                restante -= aDescontar;
            }

            producto.ListaLotes.RemoveAll(l => l.Cantidad == 0);
            producto.ActualizarPrecioVentaDesdeLotes();
        }
    }
}
