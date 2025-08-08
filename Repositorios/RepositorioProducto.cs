using Sistema_Gestion_de_Stock.Entidades;
using Sistema_Gestion_de_Stock.Utilidades;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Gestion_de_Stock.Repositorios
{
    public class
        RepositorioProducto : IRepositorio<Producto>
    {
        private List<Producto> productos = new List<Producto>();
        private static readonly string carpetaDatos = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Datos");
        private string archivo = Path.Combine(carpetaDatos, "productos.txt");


        public RepositorioProducto()
        {
            Directory.CreateDirectory(carpetaDatos);
            CargarDesdeArchivo();
        }

        public void Agregar(Producto nuevoProducto)
        {
            productos.Add(nuevoProducto);
            GuardarEnArchivo();
        }

        public void Modificar(Producto nuevoProducto)
        {
            var existe = productos.FirstOrDefault(x => x.IdProducto == nuevoProducto.IdProducto);
            if (existe != null)
            {
                existe.Nombre = nuevoProducto.Nombre;
                existe.Descripcion = nuevoProducto.Descripcion;
                existe.PrecioVenta = nuevoProducto.PrecioVenta;
                existe.IdRubro = nuevoProducto.IdRubro;
                existe.ListaLotes = nuevoProducto.ListaLotes;
                GuardarEnArchivo();
            }
        }

        public void Eliminar(int id)
        {
            var producto = productos.FirstOrDefault(x => x.IdProducto == id);
            if (producto != null)
            {
                producto.Disponible = false; //baja logica
                GuardarEnArchivo();
            }
        }

        public List<Producto> Listar()
        {
            return productos.ToList();
        }

        public Producto BuscarPorId(int id)
        {
            var productoBuscado = productos.FirstOrDefault(x => x.IdProducto == id);
            if (productoBuscado == null)
                throw new ObjetoNoEncontradoException($"No existe un Producto con ID {id}.");
            return productoBuscado;
        }

        private void CargarDesdeArchivo()
        {
            productos.Clear();
            if (!File.Exists(archivo)) return;

            var lineas = File.ReadAllLines(archivo);
            foreach (var linea in lineas)
            {
                var partes = linea.Split('|');
                var datos = partes[0].Split(';');

                int id = int.Parse(datos[0]);
                string nombre = datos[1];
                string desc = datos[2];
                double precio = double.Parse(datos[3]);
                int idRubro = int.Parse(datos[4]);
                bool disponible = bool.Parse(datos[5]);

                var producto = new Producto(id, nombre, desc, precio, idRubro, disponible);

                if (partes.Length > 1)
                {
                    for (int i = 1; i < partes.Length; i++)
                    {
                        var loteParts = partes[i].Split(',');
                        if (loteParts.Length >= 3)
                        {
                            var cantidad = int.Parse(loteParts[0]);
                            var precioCompra = double.Parse(loteParts[1]);
                            var vencimiento = DateTime.ParseExact(loteParts[2], "yyyy:MM:dd", CultureInfo.InvariantCulture);

                            producto.ListaLotes.Add(new Lote(cantidad, precioCompra, vencimiento));
                        }
                    }
                }

                productos.Add(producto);
            }
        }

        private void GuardarEnArchivo()
        {
            var lineas = productos.Select(p =>
                $"{p.IdProducto};{p.Nombre};{p.Descripcion};{p.PrecioVenta};{p.IdRubro};{p.Disponible}" +
                $"{SerializarLotes(p.ListaLotes)}"
            );
            File.WriteAllLines(archivo, lineas);
        }

        private string SerializarLotes(List<Lote> lotes)
        {
            if (lotes == null || !lotes.Any()) return "";

            var partes = lotes.Select(l =>
            $"|{l.Cantidad},{l.PrecioCompra},{l.FechaVencimiento:yyyy:MM:dd}"
            );

            return string.Join("", partes);
        }
    }
}
