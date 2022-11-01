using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsApp2.Entidades
{
    public class Remito:Administracion
    {
        #region constructores
        public Remito(DateTime fechaEntrega , string numero, DateTime fecha, string cliente, string direccion, string condicionIVA, string condicionVenta, string detalle, decimal total) : base(numero, fecha, cliente, direccion, condicionIVA, condicionVenta, detalle, total)
        {
            FechaEntrega = fechaEntrega;
        }
        #endregion

        #region propiedades
        public DateTime FechaEntrega { get; set; }

        #endregion
        
    }
}

