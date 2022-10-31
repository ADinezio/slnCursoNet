using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace WindowsApp2.Entidades
{
    public class Producto
    {
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public decimal PrecioCosto { get; set; }
        public double Margen { get; set; }
        public double IVA { get; set; }

        public decimal _PrecioBruto;
        public decimal _PrecioVenta;
        public string Proveedor { get; set; }
        public string Categoria { get; set; }
        public string SubCategoria { get; set; }


        public decimal PrecioBruto
        {
            get
            {
                this._PrecioBruto = Convert.ToDecimal(this.PrecioCosto + ((decimal)this.Margen));
                return this._PrecioBruto;
            }
        }

        public decimal PrecioVenta
        {
            get
            {
                this._PrecioVenta = Convert.ToDecimal(this._PrecioBruto + ((decimal)this.IVA));
                return this._PrecioVenta;
            }
        }
    }
}
