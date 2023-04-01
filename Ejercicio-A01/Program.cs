using System;
using Clases;

namespace Ejercicio_A01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero;
            int factorial;

            Console.Write("Ingrese un numero entero para calcular su factorial: ");
            numero = int.Parse(Console.ReadLine());

            factorial = Calculadora.Factorial(numero);


            Console.WriteLine($"El factorial de {numero} es: {factorial}");

        }
    }
}