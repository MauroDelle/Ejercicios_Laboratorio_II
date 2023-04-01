using System;
using Clases;
using Validador;

namespace Ejercicio_104
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double primerOperando;
            double segundoOperando;
            string operacionMatematica;
            string continuar = "S";

            while(Validaciones.ValidarRespuesta(continuar))
            {
                Console.Write("Ingrese el primer operando: ");
                primerOperando= double.Parse(Console.ReadLine());

                Console.Write("\nIngrese el segundo operando: ");
                segundoOperando= double.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese la operacion matemática: ");
                operacionMatematica= Console.ReadLine();    

                Console.WriteLine($"{Calculadora.Calcular(primerOperando,segundoOperando,operacionMatematica)}");

                Console.WriteLine("Desea continuar? (S/N)");
                continuar = Console.ReadLine();
            }
        }
    }
}