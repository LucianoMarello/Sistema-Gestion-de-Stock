using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Gestion_de_Stock.Entidades
{
    public class Rubro
    {
        public int IdRubro {  get; set; }
        public string Categoria { get; set; }
        public string Descripcion { get; set; }

        public Rubro(int id, string cat, string desc)
        {
            IdRubro = id;
            Categoria = cat;
            Descripcion = desc;
        }
    }
}
