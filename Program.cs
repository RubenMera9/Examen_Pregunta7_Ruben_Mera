using System;

namespace Paises
{
    // Definición de la clase abstracta 
    abstract class Pais
    {
        // Método abstracto para obtener los colores de la bandera
        public abstract string ColorBandera();

        // Método abstracto para obtener el tamaño del país
        public abstract string Tamaño();

        // Método abstracto para obtener el idioma oficial del país
        public abstract string IdiomaOficial();
    }

    // Clase Ecuador que hereda de Pais e implementa sus métodos
    class Ecuador : Pais
    {
        // Implementación del método para obtener los colores de la bandera de Ecuador
        public override string ColorBandera()
        {
            return "Amarillo, Azul y Rojo";
        }

        // Implementación del método para obtener el tamaño de Ecuador
        public override string Tamaño()
        {
            return "283,561 km²";
        }

        // Implementación del método para obtener el idioma oficial de Ecuador
        public override string IdiomaOficial()
        {
            return "Español";
        }
    }

    // Clase Brasil que hereda de Pais e implementa sus métodos
    class Brasil : Pais
    {
        // Implementación del método para obtener los colores de la bandera de Brasil
        public override string ColorBandera()
        {
            return "Verde, Amarillo, Azul y Blanco";
        }

        // Implementación del método para obtener el tamaño de Brasil
        public override string Tamaño()
        {
            return "8,515,767 km²";
        }

        // Implementación del método para obtener el idioma oficial de Brasil
        public override string IdiomaOficial()
        {
            return "Portugués";
        }
    }

    // Clase Andorra que hereda de Pais e implementa sus métodos
    class Andorra : Pais
    {
        // Implementación del método para obtener los colores de la bandera de Andorra
        public override string ColorBandera()
        {
            return "Azul, Amarillo y Rojo";
        }

        // Implementación del método para obtener el tamaño de Andorra
        public override string Tamaño()
        {
            return "468 km²";
        }

        // Implementación del método para obtener el idioma oficial de Andorra
        public override string IdiomaOficial()
        {
            return "Catalán";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Creación de una instancia de la clase Ecuador
            Ecuador ecuador = new Ecuador();

            // Creación de una instancia de la clase Brasil
            Brasil brasil = new Brasil();

            // Creación de una instancia de la clase Andorra
            Andorra andorra = new Andorra();

            // Mostrar el color de la bandera de Ecuador
            Console.WriteLine("Color de la bandera de Ecuador: " + ecuador.ColorBandera());

            // Mostrar el tamaño de Andorra
            Console.WriteLine("Tamaño de Andorra: " + andorra.Tamaño());

            // Mostrar el idioma oficial de Brasil
            Console.WriteLine("Idioma oficial de Brasil: " + brasil.IdiomaOficial());
        }
    }
}
