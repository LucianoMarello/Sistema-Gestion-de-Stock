using Sistema_Gestion_de_Stock.Entidades;
using Sistema_Gestion_de_Stock.Utilidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Gestion_de_Stock.Repositorios
{
    public class RepositorioRubro : IRepositorio<Rubro>
    {
        private List<Rubro> rubros = new List<Rubro>();
        private string archivo = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "rubros.txt");

        public RepositorioRubro()
        {
            CargarDesdeArchivo();
        }

        public void Agregar(Rubro nuevoRubro)
        {
            rubros.Add(nuevoRubro);
            GuardarEnArchivo();
        }

        public void Modificar(Rubro rubroModificado)
        {
            var existente = rubros.FirstOrDefault(r => r.IdRubro == rubroModificado.IdRubro);
            if (existente != null)
            {
                existente.Categoria = rubroModificado.Categoria;
                existente.Descripcion = rubroModificado.Descripcion;
                GuardarEnArchivo();
            }
        }


        public void Eliminar(int id)
        {
            var rubro = rubros.FirstOrDefault(r => r.IdRubro == id);
            if (rubro != null)
            {
                rubros.Remove(rubro);
                GuardarEnArchivo();
            }
        }

        public List<Rubro> Listar()
        {
            return rubros;
        }

        public Rubro BuscarPorId(int id)
        {
            var rubro = rubros.FirstOrDefault(r => r.IdRubro == id);
            if (rubro == null)
                throw new ObjetoNoEncontradoException($"No se encontró un rubro con ID {id}.");
            return rubro;
        }

        public int ObtenerProximoId()
        {
            return rubros.Any() ? rubros.Max(r => r.IdRubro) + 1 : 1;
        }

        private void CargarDesdeArchivo()
        {
            rubros.Clear();
            if (!File.Exists(archivo)) return;

            var lineas = File.ReadAllLines(archivo);
            foreach (var linea in lineas)
            {
                var partes = linea.Split(';');
                int id = int.Parse(partes[0]);
                string categoria = partes[1];
                string descripcion = partes[2];

                rubros.Add(new Rubro(id, categoria, descripcion));
            }
        }

        private void GuardarEnArchivo()
        {
            var lineas = rubros.Select(r => $"{r.IdRubro};{r.Categoria};{r.Descripcion}");
            File.WriteAllLines(archivo, lineas);
        }
    }
}
