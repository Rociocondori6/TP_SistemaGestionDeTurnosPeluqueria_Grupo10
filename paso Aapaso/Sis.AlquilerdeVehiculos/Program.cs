using RentACar.Core.Data;
using RentACar.Core.Services;

// Asegurar que la base de datos y las tablas se creen automáticamente al iniciar la app
using (var db = new RentACarDbContext())
{
    db.Database.EnsureCreated();
}

var servicio = new RentACarService();
bool salir = false;

while (!salir)
{
    Console.Clear();
    Console.WriteLine("========================================");
    Console.WriteLine("       SISTEMA RENT A CAR (C#)          ");
    Console.WriteLine("========================================");
    Console.WriteLine("1. Registrar un nuevo vehículo");
    Console.WriteLine("2. Registrar un nuevo cliente");
    Console.WriteLine("3. Registrar un alquiler");
    Console.WriteLine("4. Reporte: Alquileres por vehículo");
    Console.WriteLine("5. Reporte: Clientes con demora");
    Console.WriteLine("6. Reporte: Vehículos más alquilados");
    Console.WriteLine("7. Reporte: Cliente que más vehículos alquiló");
    Console.WriteLine("8. Salir");
    Console.WriteLine("========================================");
    Console.Write("\nSeleccione una opción: ");

    var opcion = Console.ReadLine();
    Console.WriteLine();

    switch (opcion)
    {
        case "1":
            Console.WriteLine("--- REGISTRAR VEHÍCULO ---");
            Console.Write("Patente / Matrícula: ");
            string patente = Console.ReadLine();

            Console.Write("Marca: ");
            string marca = Console.ReadLine();

            Console.Write("Modelo: ");
            string modelo = Console.ReadLine();

            Console.Write("Precio por Día ($): ");
            decimal precio = decimal.Parse(Console.ReadLine());

            Console.Write("Cantidad disponible (Stock): ");
            int cant = int.Parse(Console.ReadLine());

            try
            {
                servicio.RegistrarVehiculo(patente, marca, modelo, precio, cant);
                Console.WriteLine("\n¡Vehículo registrado con éxito!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"\nError al registrar vehículo: {ex.Message}");
            }
            break;

        case "2":
            Console.WriteLine("--- REGISTRAR CLIENTE ---");
            Console.Write("Nombre: ");
            string nombre = Console.ReadLine();

            Console.Write("Apellido: ");
            string apellido = Console.ReadLine();

            Console.Write("DNI: ");
            string dni = Console.ReadLine();

            Console.Write("Número de Licencia de Conducir: ");
            string licencia = Console.ReadLine();

            Console.Write("Teléfono: ");
            string tel = Console.ReadLine();

            try
            {
                servicio.RegistrarCliente(nombre, apellido, dni, licencia, tel);
                Console.WriteLine("\n¡Cliente registrado con éxito!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"\nError al registrar cliente: {ex.Message}");
            }
            break;

        case "3":
            Console.WriteLine("--- REGISTRAR ALQUILER ---");
            Console.Write("ID del Cliente: ");
            int clienteId = int.Parse(Console.ReadLine());

            Console.Write("IDs de vehículos a alquilar (separados por coma, ej: 1,2): ");
            var idsInput = Console.ReadLine();
            var vehiculoIds = idsInput.Split(',').Select(int.Parse).ToList();

            Console.Write("Cantidad de días contratados: ");
            int dias = int.Parse(Console.ReadLine());

            Console.Write("Porcentaje de seguro (ingrese 0,05 para 5%, 0,10 para 10%, o 0,15 para 15%): ");
            decimal seguro = decimal.Parse(Console.ReadLine());

            try
            {
                servicio.RegistrarAlquiler(clienteId, vehiculoIds, dias, seguro);
                Console.WriteLine("\n¡Alquiler registrado correctamente!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"\nError al registrar alquiler: {ex.Message}");
            }
            break;

        case "4":
            servicio.MostrarReporteAlquilerPorVehiculo();
            break;

        case "5":
            servicio.MostrarReporteClientesConDemora();
            break;

        case "6":
            servicio.MostrarVehiculosMasAlquilados();
            break;

        case "7":
            servicio.MostrarClienteEstrella();
            break;

        case "8":
            salir = true;
            Console.WriteLine("Saliendo del sistema... ¡Hasta luego!");
            continue;

        default:
            Console.WriteLine("Opción no válida. Por favor, intente de nuevo.");
            break;
    }

    Console.WriteLine("\nPresione cualquier tecla para continuar...");
    Console.ReadKey();
}