using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace sistemas_de_banco
{
    internal class CuentaPlus : Cuenta
    {
        public double LimiteDescubierto { get; set; }
        public CuentaPlus(string numeroCuenta, string nombreTitular, double saldoInicial)
            : base(numeroCuenta, nombreTitular, saldoInicial)

        {
            TipoCuenta = "Plus";

        }
        public override void Retirar(double importe)
        {
            if (importe <= 0)
            {
                Console.WriteLine("Importe Imvalido.");
                return;
            }
            double total = importe + (importe * 0.025);

            if (Saldo >= total)
            {
                Saldo -= total;
                Console.WriteLine("Retiro Realizado.");

            }
            else
            {
                Console.WriteLine("Saldo Insuficiente.");
            }
        }
    }
}

        
    




