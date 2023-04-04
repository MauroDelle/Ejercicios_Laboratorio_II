using Veterinaria;

namespace Ejercicio_A02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Crear un cliente con un perro sin vacunar;
            Cliente cliente1 = new Cliente("Mauro","Delle chiaie","Calle falsa 1223","42303856");
            Mascota perro1 = new Mascota("Fido", "Perro", new DateTime(2020,1,1));
            cliente1.AgregarMascota(perro1);

            //Creo cliente con un gato con la vacuna "Triple Felina"
            Cliente cliente2 = new Cliente("María","Gonzalez", "Calle 456","1154678068");
            Mascota gato1 = new Mascota("Garfield", "Gato",new DateTime(2019,5,10));
            Vacuna tripleFelina = new Vacuna("Triple Felina");
            gato1.AgregarVacuna(tripleFelina);
            cliente2.AgregarMascota(gato1);

            //Crear cliente con un gato sin vacunas y un perro con la vacuna contra la rabia
            Cliente cliente3 = new Cliente("Luisa", "Martínez", "Calle 789", "55555555");
            Mascota gato2 = new Mascota("Michi", "Gato", new DateTime(2022, 1, 1));
            Mascota perro2 = new Mascota("Rufus", "Perro", new DateTime(2020, 3, 3));
            Vacuna vacunaRabia = new Vacuna("Rabia");
            perro2.AgregarVacuna(vacunaRabia);
            cliente3.AgregarMascota(gato2);
            cliente3.AgregarMascota(perro2);

            //Muestro info del cliente con un perro sin vacunar
            Console.WriteLine($"Cliente con un perro sin vacunar: {cliente1.Mostrar()}");

            //Muestro info del cliente con un gato con la vacuna "Triple Felina"
            Console.WriteLine($"\nCliente con un gato con la vacuna 'Triple Felina': {cliente2.Mostrar()}");

            Console.WriteLine($"\nCliente con un gato sin vacunas y un perro con la vacuna contra la rabia: {cliente3.Mostrar()}");
        }
    }
}