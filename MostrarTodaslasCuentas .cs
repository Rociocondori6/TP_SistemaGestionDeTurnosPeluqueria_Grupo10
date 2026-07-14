using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistemas_de_bacos
{
    public class MostrarTodaslasCuentas
    {
        public static void Moastar(List<Cuenta> cuentas)
        {
            if (cuentas.Count == 0)
            {
                Console.WriteLine("No hay cuentas registradas.");
                return;
            }
            Console.WriteLine("/n LISTADO DE CUENTAS");
            foreach (Cuenta cuenta in cuentas)
            {
                Console.WriteLine("---------------------------");
                Console.WriteLine("Número: " + cuenta.NumeroCuenta);
                Console.WriteLine("Titular: " + cuenta.NombreTitular);
                Console.WriteLine("Tipo: " + cuenta.TipoCuenta);
                Console.WriteLine("Saldo: $" + cuenta.Saldo);
            }
        }
    }
}

    
