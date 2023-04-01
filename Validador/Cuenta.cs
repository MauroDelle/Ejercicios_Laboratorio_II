using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Cuenta
    {
        private string titular;
        private decimal dineroEnCuenta;

        public Cuenta(string titular, decimal dineroEnCuenta)
        {
            this.titular = titular;
            this.dineroEnCuenta = dineroEnCuenta;
        }

        public string GetTitular()
        {
            return titular;
        }
        public decimal GetCantidad()
        {
            return dineroEnCuenta; 
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Razon Social: {GetTitular()}");
            sb.AppendLine($"Cantidad: {GetCantidad()}");
            
            return sb.ToString();   
        }

        public void Ingresar(decimal monto)
        {
            if(monto > 0)
            {
                dineroEnCuenta += monto;
            }
        }

        public void Retirar(decimal monto)
        {
            dineroEnCuenta-= monto;
        }




    }
}
