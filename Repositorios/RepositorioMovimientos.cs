using Sistema_Gestion_de_Stock.Entidades;
using Sistema_Gestion_de_Stock.Utilidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Gestion_de_Stock.Repositorios
{
    public class RepositorioMovimientos
    {
        private List<Movimiento> movimientos = new List<Movimiento>();
        private string archivo = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Datos", "movimientos.txt");

        public void Agregar(Movimiento m)
        {
            movimientos.Add(m);
            GuardarEnArchivo();
        }

        public List<Movimiento> Listar() => movimientos.ToList();

        private void GuardarEnArchivo()
        {
            var lineas = movimientos.Select(m =>
            {
                if (m is Ingreso i)
                {
                    return $"Ingreso;{i.IdMovimiento};{i.IdProducto};{i.Fecha};{i.Cantidad};{i.IdProveedor};{i.PrecioCompra};{i.FechaVencimiento:yyyy-MM-dd}";
                }
                else if (m is Egreso e)
                {
                    return $"Egreso;{e.IdMovimiento};{e.IdProducto};{e.Fecha};{e.Cantidad};{e.Tipo}";
                }
                return "";
            });
            File.WriteAllLines(archivo, lineas);
        }

        public void CargarDesdeArchivo()
        {
            movimientos.Clear();

            if (!File.Exists(archivo))
                return;

            var lineas = File.ReadAllLines(archivo);

            foreach (var linea in lineas)
            {
                var partes = linea.Split(';');
                if (partes.Length == 0) continue;

                string tipo = partes[0];

                if (tipo == "Ingreso" && partes.Length == 8)
                {
                    int id = int.Parse(partes[1]);
                    int idProducto = int.Parse(partes[2]);
                    DateTime fecha = DateTime.Parse(partes[3]);
                    int cantidad = int.Parse(partes[4]);
                    int idProveedor = int.Parse(partes[5]);
                    double precioCompra = double.Parse(partes[6]);
                    DateTime fechaVenc = DateTime.Parse(partes[7]);

                    movimientos.Add(new Ingreso(id, idProducto, fecha, cantidad, idProveedor, fechaVenc, precioCompra));
                }
                else if (tipo == "Egreso" && partes.Length == 6)
                {
                    int id = int.Parse(partes[1]);
                    int idProducto = int.Parse(partes[2]);
                    DateTime fecha = DateTime.Parse(partes[3]);
                    int cantidad = int.Parse(partes[4]);
                    TipoEgreso tipoEgreso = Enum.Parse<TipoEgreso>(partes[5]);

                    movimientos.Add(new Egreso(id, idProducto, fecha, cantidad, tipoEgreso));
                }
            }
        }
    }
}
