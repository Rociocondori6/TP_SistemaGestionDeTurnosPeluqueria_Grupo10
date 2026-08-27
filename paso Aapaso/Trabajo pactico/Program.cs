using System;
using System.Collections.Generic;
using Microsoft.Identity.Client;
using AccesoDatos;


namespace AccesoDatos
{ 
    static class Program
    {
        static void Main(string[] args)
        {
            using (var context = new ApplitionsDbContext())
            {
                context_Data Base = new context_Data(context);
            }
            int opcion = 0;

            do
            {
                Console.WriteLine("=== GESTION DE MUSICA ===");
                Console.WriteLine("1. Alta artista");
                Console.WriteLine("2. Alta canciones ");
                Console.WriteLine("3.Ver cansiones");
                Console.WriteLine("4. Mostra canciones mas largas ");
                Console.WriteLine("5. Cantidad total de caciones ");
                Console.WriteLine("6. Mostrar canciones ordenadas alfaveticamente por titulo");
                Console.WriteLine("7. Verificar existencia de canciones registradas ");
                Console.Write("/nElija una opción: ");

                if (!int.TryParse(Console.ReadLine(), out opcion))
                {
                    opcion = -1;
                }

                using var context = new ApplitionsDbContext();
                {
                    switch (opcion)
                    {
                        case 1:
                            Console.Clear();
                            Console.Write("Ingrese el nombre del artista: ");
                            string nombreArtista = Console.ReadLine();

                            var artista = new Artista { Nombre = nombreArtista };
                            context.Artista.Add(artista);
                            context.SaveChanges();

                            Console.WriteLine("\n¡Artista registrado con éxito!");
                            break;

                        case 2:
                            Console.Clear();
                            Console.WriteLine("--- Artistas disponibles ---");
                            var artistas = context.Artistas.ToList();
                            if (!artistas.Any())
                            {
                                Console.WriteLine("Primero debe registrar al menos un artista.");
                                break;
                            }

                            foreach (var a in artistas)
                            {
                                Console.WriteLine($"ID: {a.Id} - Nombre: {a.Nombre}");
                            }

                            Console.Write("\nIngrese el Título de la canción: ");
                            string titulo = Console.ReadLine();
                            Console.Write("Ingrese la duración en segundos: ");
                            int.TryParse(Console.ReadLine(), out int duracion);
                            Console.Write("Ingrese el ID del artista correspondiente: ");
                            int.TryParse(Console.ReadLine(), out int artistaId);

                            var cancion = new Canciones
                            {
                                Titulo = titulo,
                                DuracionSegundos = duracion,
                                ArtistaId = artistaId
                            };

                            context.Canciones.Add(cancion);
                            context.SaveChanges();
                            Console.WriteLine("\n¡Canción registrada con éxito!");
                            break;

                        case 3:
                            Console.Clear();
                            Console.WriteLine("--- Lista de Canciones ---");
                            var listaCanciones = context.Canciones.Include(c => c.Artista).ToList();

                            if (!listaCanciones.Any())
                            {
                                Console.WriteLine("No hay canciones registradas.");
                            }
                            else
                            {
                                foreach (var c in listaCanciones)
                                {
                                    Console.WriteLine($"- Título: {c.Titulo} | Duración: {c.DuracionSegundos}s | Artista: {c.Artista?.Nombre}");
                                }
                            }
                            break;

                        case 4:
                            Console.Clear();
                            Console.WriteLine("--- Canciones más largas (más de 3 minutos / 180s por ejemplo) ---");
                            var largas = context.Canciones.Include(c => c.Artista).Where(c => c.DuracionSegundos > 180).ToList();

                            if (!largas.Any())
                            {
                                Console.WriteLine("No hay canciones que superen los 180 segundos.");
                            }
                            else
                            {
                                foreach (var c in largas)
                                {
                                    Console.WriteLine($"- {c.Titulo} ({c.DuracionSegundos}s) - {c.Artista?.Nombre}");
                                }
                            }
                            break;

                        case 5:
                            Console.Clear();
                            int total = context.Canciones.Count();
                            Console.WriteLine($"Cantidad total de canciones registradas: {total}");
                            break;

                        case 6:
                            Console.Clear();
                            Console.WriteLine("--- Canciones ordenadas alfabéticamente ---");
                            var ordenadas = context.Canciones.Include(c => c.Artista).OrderBy(c => c.Titulo).ToList();

                            foreach (var c in ordenadas)
                            {
                                Console.WriteLine($"- {c.Titulo} ({c.Artista?.Nombre})");
                            }
                            break;

                        case 7:
                            Console.Clear();
                            bool existen = context.Canciones.Any();
                            if (existen)
                                Console.WriteLine("Sí, existen canciones registradas en el sistema.");
                            else
                                Console.WriteLine("No hay canciones registradas actualmente.");
                            break;

                        case 0:
                            Console.WriteLine("Saliendo del programa...");
                            break;

                        default:
                            Console.WriteLine("Opción no válida.");
                            break;
                    }
                }

                if (opcion != 0)
                {
                    Console.WriteLine("\nPresione una tecla para continuar...");
                    Console.ReadKey();
                }

            } while (opcion != 0);
        }
    }




}

                

    


