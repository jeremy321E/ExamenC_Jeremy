using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenC
{
    public class ProductoManager : IProductoManager
    {
        private List<Producto> productos;

        public ProductoManager()
        {
            productos = new List<Producto>();
        }

        public void IntroducirProducto(Producto producto)
        {
            if (productos.Any(p => p.Codigo == producto.Codigo))
            {
                Console.WriteLine("Ya existe un producto con ese código.");
                return;
            }
            productos.Add(producto);
            Console.WriteLine("Producto añadido correctamente.");
        }

        public void EliminarProducto(string codigo)
        {
            Producto producto = productos.FirstOrDefault(p => p.Codigo == codigo);
            if (producto != null)
            {
                productos.Remove(producto);
                Console.WriteLine("Producto eliminado correctamente.");
            }
            else
            {
                Console.WriteLine("Producto no encontrado.");
            }
        }

        public Producto ConsultarProducto(string codigo)
        {
            return productos.FirstOrDefault(p => p.Codigo == codigo);
        }

        public void ModificarPrecio(string codigo, double nuevoPrecio)
        {
            Producto producto = ConsultarProducto(codigo);
            if (producto != null)
            {
                producto.ModificarPrecio(nuevoPrecio);
                Console.WriteLine("Precio modificado correctamente.");
            }
            else
            {
                Console.WriteLine("Producto no encontrado.");
            }
        }

        public List<Producto> ObtenerProductosMenoresDe(double precio)
        {
            return productos.Where(p => p.Precio < precio).ToList();
        }

        public List<Producto> ObtenerProductosMayoresDe(double precio)
        {
            return productos.Where(p => p.Precio > precio).ToList();
        }

        public void MostrarTodosLosProductos()
        {
            foreach (var producto in productos)
            {
                Console.WriteLine(producto);
            }
        }
    }
}
