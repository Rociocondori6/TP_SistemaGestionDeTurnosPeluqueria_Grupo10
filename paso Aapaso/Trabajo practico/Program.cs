using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using AppConsolaP;
using AppConsolaP.Models;
using AppConsolaP.Data;


class Program
{
    static void Main(string[] args)
    {
        int opcion;
        do
        {
            Console.Clear();
            Console.WriteLine("=== MENU GESTION DE MUSICA ===");
            Console.WriteLine("1. Alta artista ");
            Console.WriteLine("2. Alta cancion ");
            Console.WriteLine("3. Ver canciones ");
            Console.WriteLine("4. Mostrar canciones mas largas ");
            Console.WriteLine("5. Cantidad total de canciones ");
            Console.WriteLine("6. Mostrar canciones ordenadas alfabeticamente por titulo ");
            Console.WriteLine("7. Verificar si existen canciones registradas ");
            Console.WriteLine("0. Salir ");
            Console.Write("\nElija una opción: ");

            if (!int.TryParse(Console.ReadLine(), out opcion))
            {
                opcion = -1;
            }

            using (var context = new ApplicationDbContext())
            {
                switch (opcion)
                {
                    case 1:
                        RegistrarArtista(context);
                        break;

                    case 2:
                        RegistrarCancion(context);
                        break;

                    case 3:
                        VerCanciones(context);
                        break;

                    case 4:
                        MostrarCancionesMasLargas(context);
                        break;

                    case 5:
                        CantidadTotalCanciones(context);
                        break;

                    case 6:
                        MostrarCancionesOrdenadas(context);
                        break;

                    case 7:
                        VerificarCancionesRegistradas(context);
                        break;

                    case 0:
                        Console.WriteLine("\nSaliendo del programa...");
                        break;

                    default:
                        Console.WriteLine("\nOpción inválida. Intente de nuevo.");
                        break;
                }
            }

            if (opcion != 0)
            {
                Console.WriteLine("\nPresione cualquier tecla para continuar...");
                Console.ReadKey();
            }
        } while (opcion != 0);
    }

    private static void RegistrarArtista(ApplicationDbContext context)
    {
        Console.Clear();
        Console.WriteLine("=== ALTA DE ARTISTA === ");
        Console.Write("Ingrese el nombre del artista: ");
        string nombre = Console.ReadLine() ?? string.Empty;

        if (string.IsNullOrWhiteSpace(nombre))
        {
            Console.WriteLine("EL NOMBRE NO PUEDE ESTAR VACIO.");
            return;
        }

        var artista = new Artista { Nombre = nombre };
        context.Artistas.Add(artista);
        context.SaveChanges();

        Console.WriteLine("¡Artista registrado con éxito!");
    }

    private static void RegistrarCancion(ApplicationDbContext context)
    {
        Console.Clear();
        Console.WriteLine("=== Alta de canciones ===");

        var artistas = context.Artistas.ToList();
        if (!artistas.Any())
        {
            Console.WriteLine("No hay artistas registrados. Debe registrar al menos uno primero.");
            return;
        }

        Console.WriteLine("Artistas Disponibles:");
        foreach (var a in artistas)
        {
            Console.WriteLine($"ID: {a.Id} - Nombre: {a.Nombre}");
        }

        Console.Write("\nIngrese el ID del artista: ");
        if (!int.TryParse(Console.ReadLine(), out int artistaId) || !artistas.Any(a => a.Id == artistaId))
        {
            Console.WriteLine("ID de artista inválido.");
            return;
        }

        Console.Write("Ingrese el título de la canción: ");
        string titulo = Console.ReadLine() ?? string.Empty;

        Console.Write("Ingrese la duración en segundos: ");
        if (!int.TryParse(Console.ReadLine(), out int duracion) || duracion <= 0)
        {
            Console.WriteLine("Duración inválida.");
            return;
        }

        var cancion = new Cancion
        {
            Titulo = titulo,
            Duracion = duracion,
            ArtistaId = artistaId
        };

        context.Canciones.Add(cancion);
        context.SaveChanges();

        Console.WriteLine("¡Canción registrada con éxito!");
    }

    private static void VerCanciones(ApplicationDbContext context)
    {
        Console.Clear();
        Console.WriteLine("=== LISTA DE CANCIONES ===");

        var canciones = context.Canciones.Include(c => c.Artista).ToList();

        if (!canciones.Any())
        {
            Console.WriteLine("No hay canciones registradas.");
            return;
        }

        foreach (var c in canciones)
        {
            string nombreArtista = c.Artista != null ? c.Artista.Nombre : "Desconocido";
            Console.WriteLine($"- Título: {c.Titulo} | Duración: {c.Duracion}s | Artista: {nombreArtista}");
        }
    }

    private static void MostrarCancionesMasLargas(ApplicationDbContext context)
    {
        Console.Clear();
        Console.WriteLine("=== CANCIONES MÁS LARGAS (Ej. > 3 minutos o Top) ===");

        if (!context.Canciones.Any())
        {
            Console.WriteLine("No hay canciones registradas.");
            return;
        }

        var cancionesLargas = context.Canciones.Include(c => c.Artista)
                                               .Where(c => c.Duracion > 180)
                                               .ToList();

        if (!cancionesLargas.Any())
        {
            Console.WriteLine("No hay canciones que duren más de 3 minutos (180 segundos).");
            return;
        }

        foreach (var c in cancionesLargas)
        {
            string nombreArtista = c.Artista != null ? c.Artista.Nombre : "Desconocido";
            Console.WriteLine($"- {c.Titulo} ({c.Duracion}s) - {nombreArtista}");
        }
    }

    private static void CantidadTotalCanciones(ApplicationDbContext context)
    {
        Console.Clear();
        Console.WriteLine("=== CANTIDAD TOTAL DE CANCIONES ===");
        int total = context.Canciones.Count();
        Console.WriteLine($"Total de canciones registradas: {total}");
    }

    private static void MostrarCancionesOrdenadas(ApplicationDbContext context)
    {
        Console.Clear();
        Console.WriteLine("=== CANCIONES ORDENADAS ALFABÉTICAMENTE ===");

        var canciones = context.Canciones.Include(c => c.Artista)
                                         .OrderBy(c => c.Titulo)
                                         .ToList();

        if (!canciones.Any())
        {
            Console.WriteLine("No hay canciones registradas.");
            return;
        }

        foreach (var c in canciones)
        {
            string nombreArtista = c.Artista != null ? c.Artista.Nombre : "Desconocido";
            Console.WriteLine($"- {c.Titulo} ({c.Duracion}s) - Artista: {nombreArtista}");
        }
    }

    private static void VerificarCancionesRegistradas(ApplicationDbContext context)
    {
        Console.Clear();
        Console.WriteLine("=== VERIFICAR EXISTENCIA DE CANCIONES ===");
        bool existen = context.Canciones.Any();

        if (existen)
        {
            Console.WriteLine("Sí, existen canciones registradas en el sistema.");
        }
        else
        {
            Console.WriteLine("No hay canciones registradas actualmente.");
        }
    }
}