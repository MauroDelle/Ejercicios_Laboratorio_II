using Validador;
using System;

namespace Ejercicio_101
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero;
            int minimo = 100;
            int maximo = -100;
            int suma = 0;
            float promedio;

            for (int i = 0; i <= 10; i++)
            {
                Console.Write("Ingrese un numero: ");
                numero = int.Parse(Console.ReadLine());

                //valido si el numero esta dentro del rango permitido
                if(Validaciones.Validar(numero,-100,100))
                {
                    if(numero < minimo)
                    {
                        minimo = numero;
                    }

                    if(numero > maximo)
                    {
                        maximo = numero;
                    }

                    suma += numero;
                }
                else
                {
                    Console.WriteLine("El número ingresado no está dentro del rango permitido.");
                    i--; // Volver a pedir el número
                }
            }

            promedio = (float)suma / 10;

            Console.WriteLine("El valor mínimo ingresado es: {0}", minimo);
            Console.WriteLine("El valor máximo ingresado es: {0}", maximo);
            Console.WriteLine("El promedio es: {0}", promedio);

        }
    }
}