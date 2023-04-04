using Clases;

namespace Ejercicio_I03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Estudiante estudiante1 = new Estudiante("Delle chiaie", "11627", "Mauro");
            Estudiante estudiante2 = new Estudiante("Bessio", "43576", "rocio");
            Estudiante estudiante3 = new Estudiante("Palmer", "22784", "Karina");

            estudiante1.SetNotaPrimerParcial(4);
            estudiante1.SetNotaSegundoParcial(6);
            estudiante2.SetNotaPrimerParcial(10);
            estudiante2.SetNotaSegundoParcial(9);

            Console.WriteLine($"Alumno 1: \n {estudiante1.Mostrar()}");
            Console.WriteLine($"Alumno 2: \n {estudiante2.Mostrar()}");
        }
    }
}