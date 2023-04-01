using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Estudiante
    {
        string apellido;
        string legajo;
        string nombre;
        private int notaPrimerParcial;
        private int notaSegundoParcial;
        private static Random random;


        static Estudiante()
        {
            random = new Random();
        }

        public Estudiante(string apellido, string legajo, string nombre)
        {
            this.apellido = apellido;
            this.legajo = legajo;
            this.nombre = nombre;
        }

        public string GetNombre()
        {
            return nombre;
        }

        public string GetApellido()
        {
            return apellido;    
        }

        public string GetLegajo()
        {
            return legajo;
        }

        public int GetNotaPrimerParcial()
        {
            return notaPrimerParcial;
        }

        public int GetNotaSegundoParcial()
        {
            return notaSegundoParcial;
        }

        public void SetNotaPrimerParcial(int notaPrimerParcial)
        {
            this.notaPrimerParcial = notaPrimerParcial;
        }

        public void SetNotaSegundoParcial(int notaSegundoParcial)
        {
            this.notaSegundoParcial= notaSegundoParcial;
        }

        private double CalcularPromedio()
        {
            return (notaPrimerParcial + notaSegundoParcial) / 2;
        }

        private double CalcularNotaFinal()
        {
            double notaFinal = -1;

            if(notaPrimerParcial >= 4 && notaSegundoParcial >= 4) //verificar si ambas notas son mayores o iguales a 4
            {
                notaFinal = random.Next(6,11); //genero un número aleatorio entre 6 y 10 inclusive
            }
            return notaFinal;
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Nombre: {GetNombre()}");
            sb.AppendLine($"Apellido: {GetApellido()}");
            sb.AppendLine($"Legajo: {GetLegajo()}");
            sb.AppendLine($"Nota Primer Parcial: {GetNotaPrimerParcial()}");
            sb.AppendLine($"Nota Primer Parcial: {GetNotaSegundoParcial()}");
            sb.AppendLine($"Promedio: {CalcularPromedio()}");
            sb.AppendLine($"Nota Final: {CalcularNotaFinal()}");
            return sb.ToString();
        }







    }
}
