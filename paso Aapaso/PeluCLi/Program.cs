using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using PeluCre.Data;
using PeluCre.Models;

namespace PeluCli
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>();
            optionsBuilder.UseSqlite("Data Source=peluqueria.db");

            using (var context = new ApplicationDbContext(optionsBuilder.Options))
            {
                context.Database.EnsureCreated();

                bool salir = false;
                while (!salir)
                {
                    Console.Clear();
                    Console.WriteLine("==========================================");
                    Console.WriteLine("SISTEMA DE GESTION DE TURNOS - PELUQUERIA");
                    Console.WriteLine("==========================================");
                    Console.WriteLine("1. Registrar nuevo Cliente ");
                    Console.WriteLine("2. Listar Clientes");
                    Console.WriteLine("3. Registrar nuevo Estilista");
                    Console.WriteLine("4. Listar Estilistas");
                    Console.WriteLine("5. Salir ");
                    Console.Write("\nSelecciona una opción: ");

                    string? opcion = Console.ReadLine();

                    switch (opcion)
                    {
                        case "1":
                            Console.Clear();
                            Console.WriteLine(" --- Registrar nuevo Cliente ---");
                            Console.Write("Nombre: ");
                            string nombre = Console.ReadLine() ?? string.Empty;
                            Console.Write("Apellido: ");
                            string apellido = Console.ReadLine() ?? string.Empty;
                            Console.Write("Telefono: ");
                            string telefono = Console.ReadLine() ?? string.Empty;
                            Console.Write("Email: ");
                            string email = Console.ReadLine() ?? string.Empty;

                            var nuevoCliente = new Cliente
                            {
                                Nombre = nombre,
                                Apellido = apellido,
                                Telefono = telefono,
                                Email = email
                            };

                            context.Clientes.Add(nuevoCliente);
                            context.SaveChanges();

                            Console.WriteLine("\n¡Cliente registrado con éxito!");
                            Console.WriteLine("\nPresiona una tecla para continuar...");
                            Console.ReadKey();
                            break;

                        case "2":
                            Console.Clear();
                            Console.WriteLine(" --- Lista de Clientes ---");
                            var clientes = context.Clientes.ToList();

                            if (clientes.Count == 0)
                            {
                                Console.WriteLine("No hay clientes registrados.");
                            }
                            else
                            {
                                foreach (var c in clientes)
                                {
                                    Console.WriteLine($"ID: {c.Id} | Nombre: {c.Nombre} {c.Apellido} | Tel: {c.Telefono} | Email: {c.Email}");
                                }
                            }

                            Console.WriteLine("\nPresiona una tecla para continuar...");
                            Console.ReadKey();
                            break;

                        case "3":
                            Console.Clear();
                            Console.WriteLine(" --- Registrar nuevo Estilista ---");
                            Console.Write("Nombre: ");
                            string nombreEstilista = Console.ReadLine() ?? string.Empty;
                            Console.Write("Especialidad: ");
                            string especialidad = Console.ReadLine() ?? string.Empty;

                            var nuevoEstilista = new Estilista
                            {
                                Nombre = nombreEstilista,
                                Especialidad = especialidad
                            };

                            context.Estilistas.Add(nuevoEstilista);
                            context.SaveChanges();

                            Console.WriteLine("\n¡Estilista registrado con éxito!");
                            Console.WriteLine("\nPresiona una tecla para continuar...");
                            Console.ReadKey();
                            break;

                        case "4":
                            Console.Clear();
                            Console.WriteLine(" --- Lista de Estilistas ---");
                            var estilistas = context.Estilistas.ToList();

                            if (estilistas.Count == 0)
                            {
                                Console.WriteLine("No hay estilistas registrados.");
                            }
                            else
                            {
                                foreach (var e in estilistas)
                                {
                                    Console.WriteLine($"ID: {e.Id} | Nombre: {e.Nombre} | Especialidad: {e.Especialidad}");
                                }
                            }

                            Console.WriteLine("\nPresiona una tecla para continuar...");
                            Console.ReadKey();
                            break;

                        case "5":
                            salir = true;
                            Console.WriteLine("\nSaliendo del sistema...");
                            break;

                        default:
                            Console.WriteLine("\nOpción no válida. Presiona una tecla para intentar de nuevo.");
                            Console.ReadKey();
                            break;
                    }
                }
            }
        }
    }
}