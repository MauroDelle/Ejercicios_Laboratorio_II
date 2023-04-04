using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veterinaria
{
    public class Mascota
    {
        private string nombre;
        private string especie;
        private DateTime FechaNacimiento;
        public List<Vacuna> HistorialVacunacion { get; set; }

        public Mascota(string nombre, string especie, DateTime fechaNacimiento)
        {
            this.nombre = nombre;
            this.especie = especie;
            FechaNacimiento = fechaNacimiento;
            HistorialVacunacion = new List<Vacuna>(); //Inicializo la lista de historial de vacunacion;
        }

        private string GetNombre()
        {
            return nombre; 
        }

        public void SetNombre(string nombre)
        {
            this.nombre = nombre;
        }


        private string GetEspecie()
        {
            return especie;
        }

        public void SetEspecie(string especie)
        {
            this.especie = especie;
        }

        private DateTime GetFechaNacimiento()
        {
            return FechaNacimiento;
        }

        public void SetFechaNacimiento(DateTime fechaNacimiento)
        {
            this.FechaNacimiento = fechaNacimiento;
        }

        public void AgregarVacuna(Vacuna vacuna)
        {
            if(HistorialVacunacion != null)
            { 
                HistorialVacunacion.Add(vacuna);
            }
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Especie: {GetEspecie()}");
            sb.AppendLine($"Nombre: {GetNombre()}");
            sb.AppendLine($"Fecha de nacimiento: {FechaNacimiento.ToShortDateString()}");
            sb.AppendLine("Historial de vacunacion: ");

            foreach (var vacuna in HistorialVacunacion)
            {
                sb.AppendLine($"-{vacuna.nombreVacuna}");
            }

            return sb.ToString();
        }
    }
}
