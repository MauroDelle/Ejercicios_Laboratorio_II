using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    internal class Boligrafo
    {
        private const short cantidadTintaMaxima = 100;
        private short tinta;
        private ConsoleColor color;

        //Las variables const no pueden ser modificadas despues de su inicializacion;
        //Una vez que se ha establecido el valor de una constante, no se puede cambiar
        //durante la ejecucion del programa;

        public Boligrafo(short tinta, ConsoleColor color)
        {
            this.tinta = tinta;
            this.color = color;
        }

        public ConsoleColor GetColor()
        {
            return color;   
        }

        public short GetTinta()
        {
            return tinta;
        }

        private short SetTinta(short tinta)
        {
            if(tinta >= 0 && tinta <= cantidadTintaMaxima)
            {
                this.tinta = tinta;
            }
            return tinta;
        }

        public void Recargar()
        {
            this.tinta = cantidadTintaMaxima;
        }

        public void Pintar(short gasto, out string dibujo)
        {
            //resto la cantidad de tinta gastada

            tinta -= gasto;

            if(tinta < 0)
            {
                tinta = 0;
            }

            dibujo = new string('*',gasto);
        }
    }
}
