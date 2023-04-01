using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Persona
    {
        private string nombre;
        private DateTime fechaDeNacimiento;
        private int dni;

        public Persona(string nombre, DateTime fechaDeNacimiento, int dni)
        {
            this.nombre = nombre;
            this.fechaDeNacimiento = fechaDeNacimiento;
            this.dni = dni;
        }


        public string GetNombre()
        {
            return nombre;
        }

        public void SetNombre(string nombre)
        {
            this.nombre = nombre;
        }

        public DateTime GetFechaDeNacimiento()
        {
            return fechaDeNacimiento;
        }

        public void SetFechaNacimiento(DateTime fechaDeNacimiento)
        {
            this.fechaDeNacimiento = fechaDeNacimiento;
        }

        public int GetDni()
        {
            return dni;
        }

        public void SetDni(int dni)
        {
            this.dni = dni;
        }

        /// <summary>
        /// utiliza la función AddYears para calcular la fecha de nacimiento de la persona sumada con su edad,
        /// y luego compara esta fecha con la fecha actual.
        /// Si todavía no ha pasado el cumpleaños de la persona, se resta 1 a la edad.
        /// </summary>
        /// <param name="fechaDeNacimiento"></param>
        /// <returns></returns>
        private int CalcularEdad(DateTime fechaDeNacimiento)
        {
            int edad;
            edad = DateTime.Today.Year - fechaDeNacimiento.Year;

            if(DateTime.Today < fechaDeNacimiento.AddYears(edad))
            {
                edad--;
            }
            return edad;
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Nombre: {GetNombre()}");
            sb.AppendLine($"Fecha de nacimiento: {GetFechaDeNacimiento()}");
            sb.AppendLine($"Documento: {GetDni()}");
            
            return sb.ToString();   
        }

        public string EsMayorDeEdad(DateTime fechaDeNacimiento)
        {
            int edad = CalcularEdad(fechaDeNacimiento);

            if(edad >= 18)
            {
                return "Es mayor de edad";
            }
            return "Es menor";
        }
    }
}
