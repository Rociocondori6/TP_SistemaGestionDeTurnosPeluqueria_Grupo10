using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistemas_de_banco
{ 
    
        class Program
        {
            static List<Cuenta> cuentas = new List<Cuenta>();

            static void Main(string[] args)
            {
                int opcion;

                do
                {
                    Console.WriteLine("\n===== SISTEMA BANCARIO =====");
                    Console.WriteLine("1. Crear cuenta");
                    Console.WriteLine("2. Depositar dinero");
                    Console.WriteLine("3. Retirar dinero");
                    Console.WriteLine("4. Consultar cuenta");
                    Console.WriteLine("5. Mostrar todas las cuentas");
                    Console.WriteLine("0. Salir");
                    Console.Write("Opción: ");

                    opcion = int.Parse(Console.ReadLine());

                    switch (opcion)
                    {
                        case 1:
                            CrearCuenta();
                            break;

                        case 2:
                            Depositar();
                            break;

                        case 3:
                            Retirar();
                            break;

                        case 4:
                            ConsultarCuenta();
                            break;

                        case 5:
                            MostrarTodas();
                            break;
                    }

                } while (opcion != 0);
            }

            static void CrearCuenta()
            {
                Console.Write("Número de cuenta: ");
                string numero = Console.ReadLine();

                if (cuentas.Any(c => c.NumeroCuenta == numero))
                {
                    Console.WriteLine("Ya existe una cuenta con ese número.");
                    return;
                }

                Console.Write("Titular: ");
                string titular = Console.ReadLine();

                Console.Write("Saldo inicial: ");
                double saldo = double.Parse(Console.ReadLine());

                if (saldo < 0)
                {
                    Console.WriteLine("El saldo debe ser mayor o igual a 0.");
                    return;
                }

                Console.WriteLine("1. Cuenta Estándar");
                Console.WriteLine("2. Cuenta Plus");
                int tipo = int.Parse(Console.ReadLine());

                if (tipo == 1)
                {
                    cuentas.Add(new CuentaEstandar(numero, titular, saldo, 50000));
                }
                else
                {
                    cuentas.Add(new CuentaPlus(numero, titular, saldo));
                }

                Console.WriteLine("Cuenta creada correctamente.");
            }

            static void Depositar()
            {
                Console.Write("Número de cuenta: ");
                string numero = Console.ReadLine();

                Cuenta cuenta = cuentas.Find(c => c.NumeroCuenta == numero);

                if (cuenta == null)
                {
                    Console.WriteLine("Cuenta no encontrada.");
                    return;
                }

                Console.Write("Importe: ");
                double importe = double.Parse(Console.ReadLine());

                cuenta.Depositar(importe);

                Console.WriteLine("Depósito realizado.");
            }

            static void Retirar()
            {
                Console.Write("Número de cuenta: ");
                string numero = Console.ReadLine();

               Cuenta cuenta = cuentas.Find(c => c.NumeroCuenta == numero);

                if (cuenta == null)
                {
                    Console.WriteLine("Cuenta no encontrada.");
                    return;
                }

                Console.Write("Importe: ");
                double importe = double.Parse(Console.ReadLine());

                cuenta.Retirar(importe);
            }

            static void ConsultarCuenta()
            {
                Console.Write("Número de cuenta: ");
                string numero = Console.ReadLine();

                Cuenta cuenta = cuentas.Find(c => c.NumeroCuenta == numero);

                if (cuenta == null)
                {
                    Console.WriteLine("Cuenta no encontrada.");
                    return;
                }

                Console.WriteLine("--------------------------");
                Console.WriteLine("Número: " + cuenta.NumeroCuenta);
                Console.WriteLine("Titular: " + cuenta.NombreTitular);
                Console.WriteLine("Tipo: " + cuenta.TipoCuenta);
                Console.WriteLine("Saldo: $" + cuenta.Saldo);
            }

            static void MostrarTodas()
            {
                Console.WriteLine("\nLISTA DE CUENTAS");

                foreach (Cuenta  cuenta in cuentas)
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
    



    











