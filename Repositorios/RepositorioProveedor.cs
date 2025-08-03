using Sistema_Gestion_de_Stock.Entidades;
using Sistema_Gestion_de_Stock.Utilidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Gestion_de_Stock.Repositorios
{
    public class RepositorioProveedor : IRepositorio<Proveedor>
    {
        private static readonly string carpetaDatos = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Datos");
        private string archivo = Path.Combine(carpetaDatos, "proveedores.txt");

        private List<Proveedor> proveedores = new List<Proveedor>();

        public RepositorioProveedor()
        {
            Directory.CreateDirectory(carpetaDatos);
            CargarDesdeArchivo();
        }

        public void Agregar(Proveedor nuevo)
        {
            proveedores.Add(nuevo);
            GuardarEnArchivo();
        }

        public void Modificar(Proveedor modificado)
        {
            var p = BuscarPorId(modificado.IdProveedor);
            p.Nombre = modificado.Nombre;
            p.Contacto = modificado.Contacto;
            p.Telefono = modificado.Telefono;
            p.Direccion = modificado.Direccion;
            GuardarEnArchivo();
        }

        public void Eliminar(int id)
        {
            var p = BuscarPorId(id);
            proveedores.Remove(p);
            GuardarEnArchivo();
        }

        public List<Proveedor> Listar()
        {
            return proveedores;
        }

        public Proveedor BuscarPorId(int id)
        {
            var p = proveedores.FirstOrDefault(x => x.IdProveedor == id);
            if (p == null) throw new ObjetoNoEncontradoException($"Proveedor con ID {id} no encontrado.");
            return p;
        }

        private void CargarDesdeArchivo()
        {
            proveedores.Clear();
            if (!File.Exists(archivo)) return;

            var lineas = File.ReadAllLines(archivo);
            foreach (var linea in lineas)
            {
                var partes = linea.Split(';');
                var proveedor = new Proveedor(
                    int.Parse(partes[0]),
                    partes[1],
                    partes[2],
                    partes[3],
                    partes[4]
                );
                proveedores.Add(proveedor);
            }
        }

        private void GuardarEnArchivo()
        {
            var lineas = proveedores.Select(p =>
                $"{p.IdProveedor};{p.Nombre};{p.Contacto};{p.Telefono};{p.Direccion}");
            File.WriteAllLines(archivo, lineas);
        }
    }
}
