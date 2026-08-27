using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistemas_de_banco
{
    public class CuentaEstandar : Cuenta
    {
        public double LimiteRetiro { get; set; }

        public CuentaEstandar(string numeroCuenta, string nombreTitular, double saldoInicial, double limiteRetiro)
            : base(numeroCuenta, nombreTitular, saldoInicial)
        {
            TipoCuenta = "Estandar";
            LimiteRetiro = limiteRetiro;

        }
        public override void Retirar(double importe)
        {
            if (importe <= 0)
            {
                Console.WriteLine("Importe Invalido.");
                return;
            }
            if (importe > LimiteRetiro)
            {
                Console.WriteLine("Supera el limite permitido.");
                return;
            }
            double total = importe + (importe * 0.05);

            if (Saldo >= total)
            {
                Saldo -= total;
                Console.WriteLine("Retiro realizado.");
            }
            else
            {
                Console.WriteLine("Saldo Insuficiente.");
            }
        }
    }
}
        
         
         
         
       
           
        
            
        
            
        
    

