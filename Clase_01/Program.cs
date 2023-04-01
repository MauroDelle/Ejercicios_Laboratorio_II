using System;

namespace Clase_01
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Ingresar 5 números por consola, guardándolos en una variable escalar.
            //Luego calcular y mostrar: el valor máximo, el valor mínimo y el promedio.
            int[] numeros = new int[5];
            int minimo;
            int maximo;
            int suma = 0;
            float promedio;

            //pido al usuario el ingreso de numeros
            Console.WriteLine("Ingrese 5 numeros: ");
            numeros[0] = int.Parse(Console.ReadLine());
            maximo = numeros[0];
            minimo = numeros[0];
            suma = numeros[0];

            for (int i = 1; i < numeros.Length; i++)
            {
                Console.Write("Ingrese 5 numeros: ");
                numeros[i] = int.Parse(Console.ReadLine());

                if (numeros[i] > maximo)
                {
                    maximo = numeros[i];
                }

                if (numeros[i] < minimo)
                {
                    minimo = numeros[i];
                }

                suma += numeros[i];
            }

            promedio = suma / numeros.Length;

            Console.WriteLine($"El número máximo es: {maximo}");
            Console.WriteLine($"El número mínimo es: {minimo}");
            Console.WriteLine($"El promedio de los números es: {promedio}");
        }
    }
}