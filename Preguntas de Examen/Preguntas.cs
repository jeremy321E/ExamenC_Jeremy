using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Preguntas_de_Examen
{
    internal class Preguntas
    {
        static void Main(string[] args)
        {
            /*
                1.	¿Qué es una clase? (0.5 puntos)
                Una clase es una plantilla que define atributos y métodos para crear y manipular objetos.
                2.	¿Qué es la encapsulación? (0.5 puntos)
                La encapsulación es un principio de POO (programación orienta a objetos) que oculta los detalles internos de una clase y expone solo lo necesario. Permite proteger los datos y controla como se accede a ellos.
                3.	¿Qué es un objeto? (0.5 puntos)
                Un objeto es una instancia de una clase que representa una entidad concreta con atributos y métodos definidos por esa clase.
                4.	¿Qué es la herencia? (0.5 puntos)
                La herencia es un mecanismo en POO que permite a una clase, llamada subclase, heredar atributos y métodos de otra clase, la cual se llamara superclase. Esto con el fin de fomentar la reutilización del código y la creación de jerarquías, siendo más eficiente la programación.
                5.	¿Qué es el polimorfismo? (0.5 puntos)
                El polimorfismo es un concepto en POO que permite que diferentes clases puedan ser tratadas a través de una interfaz común, haciendo que los métodos con el mismo nombre se comporten de manera diferente según el objetos que los llama.
                6.	¿Qué es una interfaz? (0.5 puntos)
                Una interfaz es un contrato POO que define un conjunto de métodos que una clase debe implementar. No proporciona una implementación concreta, solo las firmas de los métodos.
                7.	¿Qué es el constructor? (0.5 puntos)
                Un constructor es un método espacial en una clase que se llama automáticamente al crear un objeto, y se utiliza para inicializar los atributos del objeto.


                8.	¿Cómo crear un objeto? (0.5 puntos)
                Para crear un objeto se debe seguir paso:
                1. Definir la clase: aquí se define la clase con atributos y métodos, se establece si será public, private o protected.
                2. Instanciar la clase: Usando el constructor de la clase para crear un objeto
                Ejemplo:
////////////////////////////////////////////////////////////////////////////////////////
            public class Persona
{
    // Propiedades de la clase
    public string Nombre { get; set; }
    public int Edad { get; set; }

    // Constructor de la clase
    public Persona(string nombre, int edad)
    {
        Nombre = nombre;
        Edad = edad;
    }

    // Método de la clase
    public void Saludar()
    {
        Console.WriteLine($"Hola, mi nombre es {Nombre} y tengo {Edad} años.");
    }
}
/////////////////////////////////////////////////////////////////////////////////////////
using System;

class Program
{
    static void Main()
    {
        // Crear un objeto de la clase Persona
        Persona persona1 = new Persona("Ana", 30);
        
        // Usar un método del objeto
        persona1.Saludar();
    }
}
            */
        }
    }
}
