using System.ComponentModel;

namespace Ejercicio_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 6, 28, 496 y 8128
            int contador = 0; // Contador para llevar a cuenta de los numeros perfectos encontrados
            int numero = 6; //El primer numero perfecto es 6

            while(contador < 4) //quiero encontrar los primeros 4 números perfectos
            {
                int sum = 1; //Suma empieza en 1, ya que todo número es divisible por 1;

                for(int i = 2;i< numero; i++) //comenzamos a buscar divisores a partir de 2 hasta num -1
                {
                    if(numero % i == 0) // si i es divisor de num
                    {
                        sum += i; //sumamos i a la suma
                    }
                }
                if(sum == numero) // si la suma de los diviores e igual al número, tenemos un numero perfecto.
                {
                    Console.WriteLine(numero);
                    contador++; // Incrementamos el contador de números perfectos encontrados
                }
                numero++;   // Probamos el siguiente número
            }
        }
    }
}