using System.Runtime.ConstrainedExecution;

namespace Ejercicio_02
{
    //Ingresar un número y mostrar el cuadrado y el cubo del mismo.
    //Se debe validar que el número sea mayor que cero, caso contrario, mostrar el mensaje:
    //"ERROR. ¡Reingresar número!".
    internal class Program
    {
        static void Main(string[] args)
        {
            double numero;
            double cuadrado;
            double cubo;

            Console.Write("Ingrese un numero: ");
            numero = double.Parse(Console.ReadLine());

            while(numero <= 0)
            {
                Console.WriteLine("ERROR. ¡Reingresar número!");
                numero= double.Parse(Console.ReadLine());
            }
            
            cuadrado = Math.Pow(numero,2);
            cubo = Math.Pow(numero,3);
            Console.WriteLine($"El cuadrado de {numero} es {cuadrado}");
            Console.WriteLine($"El cubo de {numero} es {cubo}");
        }
    }
}