using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsApp2.Entidades
{
    public abstract class Persona
    {
        #region constructor
        public Persona() { }
        public Persona(string nombre, string apellido,string email, int telefono, string direccion)
        {
            Nombre = nombre;
            Apellido = apellido;
            Email = email;
            Telefono = telefono;
            Direccion = direccion;
        }
        #endregion

        #region propiedades
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Email  { get; set; }
        public int Telefono { get; set; }
        public string Direccion { get; set; }
        #endregion
    }
}
