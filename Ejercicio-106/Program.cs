namespace Ejercicio_106
{
    internal class Program
    {
        //Pedirle al usuario un año de inicio y otro de fin y mostrar todos los años bisiestos en ese rango.
        static void Main(string[] args)
        {
            int anioInicio;
            int anioFin;

            Console.WriteLine("Ingrese el año de inicio: ");
            anioInicio = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el año de fin: ");
            anioFin= int.Parse(Console.ReadLine());

            Console.WriteLine("Los anios bisiestos entre {0} y {1} son: ", anioInicio, anioFin);

            //itera sobre todos los años en el rango ingresado por el usuario

            for(int i = anioInicio;i <=anioFin;i++)
            {
                //compruebo si el año actual es bisiesto utilizando la fórmula: 
                //Un año es biciesto si es multiplo de 4. Los años múltiplos de 100 no son bisiestos.
                //salvo si ellos tambien son multiplos de 400

                if(i % 4 == 0 && (i % 100 != 0 || i % 400 == 0)) //*
                {
                    //Si el anio es bisiesto, lo muestro en pantalla
                    Console.Write(i);
                }
            }
            Console.ReadLine();
        }
    }
}
// * la condición if (i % 4 == 0 && (i % 100 != 0 || i % 400 == 0)) verifica si el año actual es divisible por 4 y, si lo es,
//verifica si el año es múltiplo de 100 pero no de 400.
//Si la condición se cumple, el año actual es bisiesto y se muestra en pantalla.