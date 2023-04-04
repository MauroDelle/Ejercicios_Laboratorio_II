using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veterinaria
{
    public class Cliente
    {
        private string Nombre;
        private string Apellido;
        private string Domicilio;
        public string Telefono;
        public List<Mascota> Mascotas { get; set; }

        public Cliente(string nombre, string apellido, string domicilio, string telefono)
        {
            Nombre = nombre;
            Apellido = apellido;
            Domicilio = domicilio;
            Telefono = telefono;
            Mascotas = new List<Mascota>();
        }

        private string GetNombre()
        {
            return Nombre;
        }

        public void SetNombre(string nombre)
        {
            this.Nombre= nombre;
        }

        private string GetApellido()
        {
            return Apellido;
        }

        public void SetApellido(string apellido)
        {
            this.Apellido= apellido;
        }

        private string GetDomicilio()
        {
            return Domicilio;
        }

        public void SetDomicilio(string domicilio)
        {
            this.Domicilio= domicilio;
        }

        private string GetTelefono()
        {
            return Telefono;
        }

        public void SetTelefono(string telefono)
        {
            this.Telefono= telefono;
        }


        public void AgregarMascota(Mascota mascota)
        {
            if(Mascotas != null)
            {
                Mascotas.Add(mascota);
            }
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Nombre: {GetNombre()}");
            sb.AppendLine($"Apellido: {GetApellido()}");
            sb.AppendLine($"Domicilio: {GetDomicilio()}");
            sb.AppendLine($"Telefono: {GetTelefono()}");

            
            foreach (var mascota in Mascotas)
            {
                sb.AppendLine(mascota.Mostrar());
            }
            
            return sb.ToString();   
        }


    }
}
