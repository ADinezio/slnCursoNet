using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsApp2.Entidades2;

namespace WindowsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            Autor autor1 = new Autor();
            Autor autor2 = new Autor();
            autor1.Nombre = "Marcos";
            autor1.Apellido = "Chicot";
            autor1.FechaNacimiento = new DateTime(1971,5,10);
            autor1.Domicilio = "Sarmiento 1524";
            autor1.Ciudad = "Madrid";
            autor1.Pais = "España";

            autor2.Nombre = "Pepe";
            autor2.Apellido = "Grillo";
            autor2.FechaNacimiento = new DateTime(1980, 10, 5);
            autor2.Domicilio = "Gascon 2356";
            autor2.Ciudad = "Bueno Aires";
            autor2.Pais = "Argentina";

            Empleado empleado1 = new Empleado();
            Empleado empleado2 = new Empleado();

            empleado1.Nombre = "Juan";
            empleado1.Apellido = "Barbacoa";
            empleado1.Titulo = "Contador";
            empleado1.FechaIngreso = new DateTime(2020,10,8);

            empleado1.Nombre = "Maria";
            empleado1.Apellido = "Lopez";
            empleado1.Titulo = "Programadora";
            empleado1.FechaIngreso = new DateTime(2018, 8, 10);

            Venta venta1 = new Venta();
            Venta venta2 = new Venta();

            venta1.Tienda = "Palito";
            venta1.NumeroOrden = 123556;
            venta1.Fecha = new DateTime(2022, 1, 10);
            venta1.Cantidad = 10;
            venta1.Titulo = "El asesinato de Pitagoras";

            venta2.Tienda = "Libros de Arena";
            venta2.NumeroOrden = 22359;
            venta2.Fecha = new DateTime(2021, 10, 1);
            venta2.Cantidad = 45;
            venta2.Titulo = "La Niebla";

            Publicador publicador1= new Publicador();
            Publicador publicador2= new Publicador();

            publicador1.Nombre = "Palito";
            publicador1.Ciudad = "Mar del Plata";
            publicador1.Domicilio = "Independecia 2258";
            publicador1.Contacto = "Juan";
            publicador1.Pais = "Argentina";

            publicador2.Nombre = "Libros de Arena";
            publicador2.Ciudad = "Mar del Plata";
            publicador2.Domicilio = "Constitucion 2258";
            publicador2.Contacto = "Carlos";
            publicador2.Pais = "Argentina";

            Titulo titulo1= new Titulo();
            Titulo titulo2 = new Titulo();

            titulo1.NombreAutor = "Marcos Chicot";
            titulo1.Tittle = "El asesinato de Pitagoras";
            titulo1.Categoria = "suspenso";
            titulo1.Precio = 2100;
            titulo1.Notas = "Agotado";

            titulo1.NombreAutor = "Stephen king";
            titulo1.Tittle = "La Niebla";
            titulo1.Categoria = "Terror";
            titulo1.Precio = 2500;
            titulo1.Notas = "Agotado";

        }
    }
}
