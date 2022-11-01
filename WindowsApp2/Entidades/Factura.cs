using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsApp2.Entidades
{
    public class Factura:Administracion
    {
        #region constructores
        public Factura(string tipo,string numero, DateTime fecha, string cliente, string direccion, string condicionIVA, string condicionVenta, string detalle, decimal total) : base(numero, fecha, cliente, direccion, condicionIVA, condicionVenta, detalle, total)
        {
            Tipo = tipo;
        }
        #endregion

        #region propiedades
        public string Tipo { get; set; }
        #endregion

     
    }
}
