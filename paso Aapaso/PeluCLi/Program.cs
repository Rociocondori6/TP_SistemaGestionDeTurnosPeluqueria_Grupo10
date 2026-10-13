using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using PeluCore.Models;
using PeluCore.Data;

namespace PeluCli
{
    class Program
    {
        static void Main(string[]  args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            using (var context = new ApplicationDbContext(new DbContextOptionBuilder<ApplicationDbContext>().UseSqlite("Data Source=peluqueria.db").Options))
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
                    Console.WriteLine("2. Lista Vlientes");
                    Console.WriteLine("3. Registrar nuevo Estilista");
                    Console.WriteLine("4. Lista Estilistas");
                    Console.WriteLine("5 . Salir ");
                    Console.Write("\nSelecciona una opción:");

                    string opcion = Console.ReadLine();

                    switch (opcion)
                    {
                        case "1":
                            Console.Clear();
                            Console.WriteLine(" --- Registrar nuevo Cliente ---");
                            Console.Write("Nombre: ");
                            string nombre = Console.ReadLine();
                            Console.WriteLine("Apellido: ");
                            string apellido = Console.ReadLine();
                            Console.WriteLine("Telefono: ");
                            string telefono = Console.ReadLine();
                            Console.WriteLine("Email: ");
                            string email = Console.ReadLine();

                            var nuevoCliente = new Cliente
                            {
                                Nombre = nombre,
                                Apellido = apellido,
                                Telefono = telefono,
                                Email = email
                            };

                            context.Clientes.Add(nuevoCliente);
                            context.SaveChanges();
                            Console.Write
                    }
                    ;


            }
        }
    }
}