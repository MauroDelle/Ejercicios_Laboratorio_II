using Clases;
using System.Globalization;

namespace Ejercicio_108
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Pedimos la fecha de nacimiento al usuario
            Console.Write("Ingrese la fecha de nacimiento (DD/MM/AAAA): ");
            DateTime fechaNacimiento = DateTime.Parse(Console.ReadLine());

            // Calculamos el número de días vividos
            int diasVividos = Calculadora.CalcularDias(fechaNacimiento);

            // Mostramos el resultado al usuario
            Console.WriteLine("Número de días vividos: {0}", diasVividos);

            Console.ReadKey();

        }
    }
}