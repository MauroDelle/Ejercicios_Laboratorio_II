using System.Runtime.CompilerServices;

namespace Ejercicio_107
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cantidadEmpleados;

            //variables para almacenar los datos de cada empleado
            string nombre;
            int antiguedad;
            double valorHora;
            double horasTrabajadas;
            double totalBruto;
            double totalNeto;
            double descuento;

            //Variables para calcular el total bruto y neto de todos los empleados
            double totalBrutoGeneral = 0;
            double totalNetoGeneral = 0;

            Console.WriteLine("Ingrese la cantidad de empleados: ");
            cantidadEmpleados = int.Parse(Console.ReadLine());

            //ahora que tengo la cantidad de empleados puedo iterarlos
            for(int i = 1; i <= cantidadEmpleados; i++)
            {
                //Solicitar al usuario los datos el empleado
                Console.WriteLine("Empleado" + i + ":");
                Console.Write("Nombre: ");
                nombre = Console.ReadLine();

                Console.Write("Antiguedad (en anios): ");
                antiguedad= int.Parse(Console.ReadLine());
                Console.Write("Valor hora: ");
                valorHora= double.Parse(Console.ReadLine());   
                Console.Write("Horas trabajadas al mes: ");
                horasTrabajadas= double.Parse(Console.ReadLine());

                //calcular el total bruto del empleado
                totalBruto = (valorHora * horasTrabajadas) + (antiguedad * 150);

                //calcular el descuento del 13%
                descuento = totalBruto * 0.13;

                //calcular el total neto del empleado;
                totalNeto = totalBruto - descuento;

                //imprimo el recibo correspondiente al empleado;
                Console.WriteLine("Recibo de sueldo: ");
                Console.WriteLine("Nombre: " + nombre);
                Console.WriteLine("Antiguedad: " + antiguedad + "años");
                Console.WriteLine("Valor hora: $" + valorHora);
                Console.WriteLine("Total bruto: $" + totalBruto);
                Console.WriteLine("Descuentos (13%): $" + descuento);
                Console.WriteLine("Total neto: $" + totalNeto);

                //sumar el total bruto y neto del empleado al total general
                totalBrutoGeneral += totalBruto;
                totalNetoGeneral += totalNeto;
            }

            //Imprimir el total bruto y neto de todos los empleados ingresados
            Console.WriteLine("\nTotal General: ");
            Console.WriteLine("Cantidad de empleados: " + cantidadEmpleados);
            Console.WriteLine("Total bruto: $" + totalBrutoGeneral);
            Console.WriteLine("Total neto : $" + totalNetoGeneral);
        }
    }
}