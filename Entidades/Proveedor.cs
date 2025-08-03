using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Gestion_de_Stock.Entidades
{
    public class Proveedor
    {
        public int IdProveedor { get; set; }
        public string Nombre { get; set; }
        public string Contacto { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }

        public Proveedor(int iD_Proveedor, string nombre, string contacto, string telefono, string direccion)
        {
            this.IdProveedor = iD_Proveedor;
            this.Nombre = nombre;
            this.Contacto = contacto;
            this.Telefono = telefono;
            this.Direccion = direccion;
        }
    }
}
