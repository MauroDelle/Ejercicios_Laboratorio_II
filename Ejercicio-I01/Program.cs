using System;
using Clases;
using Validador;

namespace Ejercicio_I01
{
    class Program
    {
        static void Main(string[] args)
        {
            Cuenta cuenta1 = new Cuenta("Mauro",120000);
            decimal monto = 0;
            string respuesta = "S";
            int opcion;

            do
            {
                Console.WriteLine("Seleccione una opcion: ");
                Console.Write("1-Mostrar" +
                              "\n2-Ingresar" +
                              "\n3-retirar" +
                              "\n4-Salir");
                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Console.WriteLine(cuenta1.Mostrar());
                        break;
                    case 2:
                        Console.Write("Ingrese el monto que desea ingresar:");
                        monto = decimal.Parse(Console.ReadLine());
                        cuenta1.Ingresar(monto);
                        break;
                    case 3:
                        Console.Write("Ingrese el monto a retirar: ");
                        monto = decimal.Parse(Console.ReadLine());
                        cuenta1.Retirar(monto);
                        break;
                    case 4:
                        Console.WriteLine("Desea realizar otra operacion? (S/N):");
                        respuesta = Console.ReadLine();
                        break;
                }
            }while(Validaciones.ValidarRespuesta(respuesta));
        }
    }
}