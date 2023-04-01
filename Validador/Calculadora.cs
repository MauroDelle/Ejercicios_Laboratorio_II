using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Calculadora
    {
        public static double Calcular(double numero1,double numero2, string operacion)
        {
            double resultado = 0;

            switch(operacion)
            {
                case "+":
                    resultado = numero1 + numero2;
                    break;
                case "-":
                    resultado = numero1 - numero2;
                    break;
                case "*":
                    resultado = numero1 * numero2;
                    break;
                case "/":
                    if(!Validar(numero2))
                    {
                        Console.WriteLine("No se puede dividir por 0");
                        resultado = 0;
                    }
                    else
                    {
                        resultado = numero1 / numero2;
                    }
                    break;
            }
            return resultado;
        }

        private static bool Validar(double numero)
        {
            if(numero != 0)
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Obtenemos la fecha actual
        /// Calculamos la diferencia entre la fecha dada y la fecha actual
        /// Obtenemos el número total de días como un número entero 
        /// Verificamos si el año de la fecha dada es bisiesto 
        /// Verificamos si la fecha dada es posterior al 29 de febrero de ese año
        /// Si es así, sumamos 1 día adicional a los días totales
        ///   si el año es bisiesto, verificamos si la fecha dada es posterior al 29 de febrero de ese año.
        //  Para hacer esto, creamos una nueva fecha que represente el 29 de febrero de ese año, 
        //  y la comparamos con la fecha dada.Si la fecha dada es posterior al 29 de febrero,
        //  significa que hay un día adicional en el año bisiesto, por lo que sumamos 1 al número total de días.
        /// Retornamos el número total de días 
        /// </summary>
        /// <param name="fecha"></param>
        /// <returns></returns>
        public static int CalcularDias(DateTime fecha)
        {
            DateTime fechaActual = DateTime.Now;
            TimeSpan diferencia = fechaActual - fecha;

            int dias = (int)diferencia.TotalDays;

            if (DateTime.IsLeapYear(fecha.Year))
            {
                if (fecha > new DateTime(fecha.Year, 2, 29))
                {

                    dias += 1;
                }

            }
            return dias;
        }



        public static int Factorial(int numero)
        {
            //Primero me fijo si el numero ingresado es 0
            if (numero == 0)
            {
                return 1;
            }
            //multiplico numero por el factorial de numero-1 
            return numero * Factorial(numero - 1);
        }

        public static int FactorialDos(int numero)
        {
            int factorial = 1;

            for (int i = numero; i > 0; i--)
            {
                factorial *= i; 
            }

            return factorial;
        }





    }
}
