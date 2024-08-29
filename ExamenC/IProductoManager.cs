using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenC
{
    interface IProductoManager
    {
        void IntroducirProducto(Producto producto);
        void EliminarProducto(string codigo);
        Producto ConsultarProducto(string codigo);
        void ModificarPrecio(string codigo, double nuevoPrecio);
        List<Producto> ObtenerProductosMenoresDe(double precio);
        List<Producto> ObtenerProductosMayoresDe(double precio);
        void MostrarTodosLosProductos();
    }
}
