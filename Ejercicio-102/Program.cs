using System;
using Validador;

namespace Ejercicio_102
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int suma = 0;
            string respuesta = "S";
            int numero;

            while (Validaciones.ValidarRespuesta(respuesta))
            {
                Console.WriteLine("Ingrese un numero entero: ");
                numero = int.Parse(Console.ReadLine());
                suma += numero;

                Console.WriteLine("Desea continuar? (S/N)");
                respuesta = Console.ReadLine();
            }
            Console.WriteLine("La suma total es : {0}", suma);
        }
    }
}