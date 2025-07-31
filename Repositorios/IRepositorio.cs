using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Gestion_de_Stock.Repositorios
{
    public interface IRepositorio<T>
    {
        void Agregar(T obj);
        void Modificar(int id, T obj);
        void Eliminar(int id);
        List<T> Listar();
        T BuscarPorId(int id);
    }
}
