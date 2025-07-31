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

        public Egreso(int idMovimiento, int idProducto, int cantidad, TipoEgreso tipo)
            : base(idMovimiento, idProducto, cantidad)
        {
            Tipo = tipo;
        }

        public override void AplicarMovimiento()
        {
            //buscar el producto y lote y bajar la cantidad
            //ordenar los lotes por vencimientos
        }
    }
}
