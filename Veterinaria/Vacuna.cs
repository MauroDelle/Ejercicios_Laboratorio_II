namespace Veterinaria
{
    public class Vacuna
    {
        public string nombreVacuna;

        public Vacuna(string nombreVacuna)
        {
            this.nombreVacuna = nombreVacuna;
        }

        private string GetNombre()
        {
            return nombreVacuna;
        }

        public void SetNombre(string nombreVacuna)
        {
            if(nombreVacuna != null)
            { 
                this.nombreVacuna = nombreVacuna;
            }
        }

        public string Mostrar()
        {
            return $"Vacuna: {nombreVacuna}";
        }
    }
}