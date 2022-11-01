using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsApp2.Entidades
{
    public class Vendedor:Persona
    {
        #region constructores
        public Vendedor() { }
        public Vendedor(string dni,string nombre, string apellido, string email, int telefono, string direccion) : base(nombre, apellido, email, telefono, direccion)
        {
            DNI = dni;
        }
        #endregion

        #region propiedades
        public string DNI { get; set; }

        #endregion

       
    }
}
