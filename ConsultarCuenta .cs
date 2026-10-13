using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistemas_de_banco
{
    public class ConsultarCuenta
    {
        public static void Consultar(List<Cuenta> cuentas)
        {
            Console.WriteLine("ingrese el numero de cuenta :");
            string numero = Console.ReadLine();

            foreach(Cuenta cuenta in cuentas)
            {
                if (cuenta.NumeroCuenta  == numero)
                {
                    Console.WriteLine(" numero: " + cuenta.NumeroCuenta);
                    Console.WriteLine("Titular: " + cuenta.NombreTitular);
                    Console.WriteLine("Saldo : $" + cuenta.Saldo);
                    return;

                }
            }
            Console.WriteLine("La cuenta no existe.");
        }
    }

}