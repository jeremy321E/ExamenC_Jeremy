using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenC
{
    public class Program
    {
        static void Main(string[] args)
        {
            ProductoManager manager = new ProductoManager();

            // Introducir productos
            manager.IntroducirProducto(new Producto("001", "Leche", 12.5));
            manager.IntroducirProducto(new Producto("002", "Pan", 1.5));
            manager.IntroducirProducto(new Producto("003", "Carne", 55.0));
            manager.IntroducirProducto(new Producto("004", "Jabón", 95.0));

            // Mostrar todos los productos
            Console.WriteLine("Todos los productos:");
            manager.MostrarTodosLosProductos();
            Console.WriteLine();

            // Eliminar un producto
            manager.EliminarProducto("002");

            // Consultar producto
            Producto producto = manager.ConsultarProducto("003");
            if (producto != null)
            {
                Console.WriteLine("Producto consultado:");
                Console.WriteLine(producto);
            }
            else
            {
                Console.WriteLine("Producto no encontrado.");
            }
            Console.WriteLine();

            // Modificar precio de un producto
            manager.ModificarPrecio("003", 60.0);

            // Mostrar productos menores de 30$
            Console.WriteLine("Productos con precio menor de 30$:");
            var productosMenores = manager.ObtenerProductosMenoresDe(30.0);
            foreach (var p in productosMenores)
            {
                Console.WriteLine(p);
            }
            Console.WriteLine();

            // Mostrar productos mayores de 60$
            Console.WriteLine("Productos con precio mayor de 60$:");
            var productosMayores = manager.ObtenerProductosMayoresDe(60.0);
            foreach (var p in productosMayores)
            {
                Console.WriteLine(p);
            }

            // Esperar a que el usuario presione una tecla antes de cerrar la consola
            Console.ReadKey();
        }
    }
}
