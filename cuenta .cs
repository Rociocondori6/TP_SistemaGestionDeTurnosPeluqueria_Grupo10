using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistemas_de_bacos
{
    public abstract class Cuenta
    {
        public string NumeroCuenta { get; set; }

        public string NombreTitular { get; set; }
        public double Saldo { get; set; }
        public string TipoCuenta { get; set; }


        public Cuenta(string numeroCuenta, string nombreTitular, double saldoinicial)
        {
            NumeroCuenta = numeroCuenta;
            NombreTitular = nombreTitular;
            Saldo = saldoinicial;
        }
        public void Depositar(double importe)
        {
            if (importe > 0)
                Saldo += importe;
            else
                Console.WriteLine("El importe debe ser mayor a 0.");

        }
        public abstract void Retirar(double importe);
    }
}
    

