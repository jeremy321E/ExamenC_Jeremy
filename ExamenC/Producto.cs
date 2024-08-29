using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenC
{
    public  class Producto
    {
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public double Precio { get; set; }
        public double Descuento { get; private set; }

        public Producto(string codigo, string nombre, double precio)
        {
            Codigo = codigo;
            Nombre = nombre;
            Precio = precio;
            CalcularDescuento();
        }

        private void CalcularDescuento()
        {
            if (Precio <= 15)
            {
                Descuento = Precio * 0.05;
            }
            else if (Precio > 15 && Precio <= 50)
            {
                Descuento = Precio * 0.25;
            }
            else if (Precio > 50 && Precio <= 90)
            {
                Descuento = Precio * 0.30;
            }
            else
            {
                Descuento = Precio * 0.50;
            }
        }

        public override string ToString()
        {
            return $"CODIGO: {Codigo}, NOMBRE: {Nombre}, PRECIO: {Precio:C2}, DESCUENTO: {Descuento:C2}";
        }

        public void ModificarPrecio(double nuevoPrecio)
        {
            Precio = nuevoPrecio;
            CalcularDescuento();
        }
    }
}
