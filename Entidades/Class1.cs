namespace Entidades
{
    public static class Calculadora
    {
        private static int primerNumero;
        private static int segundoNumero;

        static Calculadora()
        {
            primerNumero= 0;
            segundoNumero= 0;
        }
        //public - lo puedo ver desde cualquier aprte del proyecto
        //internal - Solo lo puedo ver dentro del proyecto que lo contiene
        //private - Solo lo puedo ver desde la clase

        public static int Contar()
        {
            return 2;
        }

    }
}