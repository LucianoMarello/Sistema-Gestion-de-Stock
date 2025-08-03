using Sistema_Gestion_de_Stock.Entidades;
using Sistema_Gestion_de_Stock.Utilidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Gestion_de_Stock.Repositorios
{
    public class 
        RepositorioProducto : IRepositorio<Producto>
    {
        public List<Producto> productos = new List<Producto>();
        private string archivo = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "productos.txt");

        public RepositorioProducto()
        {
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
                existe.Stock = nuevoProducto.Stock;
                existe.IdRubro = nuevoProducto.IdRubro;
                GuardarEnArchivo();
            }
        }

        public void Eliminar(int id)
        {
            var producto = productos.FirstOrDefault(x => x.IdProducto == id);
            if (producto != null)
            {
                producto.Disponible = false;
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
                var partes = linea.Split(';');

                int idProducto = int.Parse(partes[0]);
                string nombre = partes[1];
                string descripcion = partes[2];
                int cantidad = int.Parse(partes[3]);
                double precio = double.Parse(partes[4]);
                int idRubro = int.Parse(partes[5]);
                bool disponible = bool.Parse(partes[6]);
                List<int> idsLotes = partes[7].Split(',', StringSplitOptions.RemoveEmptyEntries)
                   .Select(id => int.Parse(id))
                   .ToList();

                Producto p = new Producto
                (
                    idProducto,
                    nombre,
                    descripcion,
                    cantidad,
                    precio,
                    idRubro
                );
                p.Disponible = disponible;
                p.ListaLotes = idsLotes;
                productos.Add(p);
            }
        }

        private void GuardarEnArchivo()
        {
            var lineas = productos.Select(p =>
            $"{p.IdProducto};{p.Nombre};{p.Descripcion};{p.Stock};{p.PrecioVenta};{p.IdRubro};{p.Disponible};{string.Join(",", p.ListaLotes)}");
            File.WriteAllLines(archivo, lineas);
        }


    }
}
