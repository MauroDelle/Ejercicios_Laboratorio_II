namespace Validador
{
    public class Validaciones
    {
        public static bool Validar(int valor, int min,int max)
        {
            //Verificar si el valor esta dentro del rango
            return valor > min && valor < max;
        }
        public static bool ValidarRespuesta(string respuesta)
        {
           // respuesta = respuesta.ToUpper();
            return respuesta.ToUpper() == "S";
        }
    }
}