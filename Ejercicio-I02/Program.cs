using System;
using Clases;

namespace Ejercicio_I02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Persona persona1 = new Persona("Mauro", new DateTime(2001,11,06),43785741);
            Persona persona2 = new Persona("Claudio", new DateTime(1967,11,25),18347983);
            Persona persona3 = new Persona("Karina", new DateTime(1968, 11, 26), 19786458);


            Console.WriteLine($"Persona 1: {persona1.Mostrar()}");
            Console.WriteLine($"Persona 2: {persona2.Mostrar()}");
            Console.WriteLine($"Persona 3: {persona3.Mostrar()}");

            Console.WriteLine($"{persona1.EsMayorDeEdad(new DateTime(2001, 11, 6))}");
        }
    }
}