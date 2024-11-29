using System;

namespace UniversidadCoppel
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenidos a UMI/Universidad Coppel");

            // Solicitar y validar el nombre
            Console.Write("Ingrese su Nombre completo: ");
            string nombre = Console.ReadLine();
            while (string.IsNullOrWhiteSpace(nombre))
            {
                Console.WriteLine("El nombre no puede estar vacío. Por favor, ingréselo de nuevo.");
                nombre = Console.ReadLine();
            }

            // Solicitar y validar la edad
            Console.Write("Ingrese su Edad: ");
            string entradaEdad = Console.ReadLine();
            while (string.IsNullOrWhiteSpace(entradaEdad) || !int.TryParse(entradaEdad, out int edad))
            {
                Console.WriteLine("Edad inválida. Por favor, ingrese un número válido para la edad.");
                entradaEdad = Console.ReadLine();
            }

            // Solicitar y validar la fecha de nacimiento
            Console.Write("Ingrese su Fecha de Nacimiento (dd/MM/yyyy): ");
            string entradaFecha = Console.ReadLine();
            while (string.IsNullOrWhiteSpace(entradaFecha) || !DateTime.TryParse(entradaFecha, out DateTime fechaNacimiento))
            {
                Console.WriteLine("Fecha inválida. Por favor, ingrese una fecha válida en el formato dd/MM/yyyy.");
                entradaFecha = Console.ReadLine();
            }

            // Solicitar y validar la carrera
            Console.Write("Ingrese la Carrera a la que desea ingresar: ");
            string carrera = Console.ReadLine();
            while (string.IsNullOrWhiteSpace(carrera))
            {
                Console.WriteLine("La carrera no puede estar vacía. Por favor, ingrésela de nuevo.");
                carrera = Console.ReadLine();
            }

            // Mostrar mensaje de bienvenida
            Console.WriteLine($"\nGracias {nombre} por formar parte de UMI/Universidad Coppel, Bienvenido a la carrera {carrera}.");

            // Pausa para mantener abierta la consola
            Console.WriteLine("\nPresione cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}
