using HolaDotNet;

List<Producto> inventario = new List<Producto>();

// 1. Añadir Productos al Inventario (con IDs únicos)
inventario.Add(new Producto(1, "Laptop Gamer", 1200.50, 5));
inventario.Add(new Producto(2, "PC Sobremesa", 1400.50, 4));
inventario.Add(new Producto(3, "Monitor", 700.50, 8)); 

Console.WriteLine("--- Inventario Actual ---");

// 2. Mostrar todos los productos en el inventario (usando foreach y ObtenerInfoCompleta())
foreach (Producto productoIndividual in inventario) // 'productoIndividual' es una variable temporal que toma cada Producto de la lista
{
    Console.WriteLine(productoIndividual.ObtenerInfoCompleta());
}

Console.WriteLine("\n--- Simulación de Venta ---");

// 3. Simular una venta y actualizar el inventario
// Accedemos al primer producto de la lista (índice 0)
Producto productoParaVender = inventario[0]; // Esto obtiene el objeto "Laptop Gamer"
Console.WriteLine($"Intentando vender de: {productoParaVender.Nombre}");

productoParaVender.Vender(2); // Llamamos al método Vender de ESE producto
// Volvemos a imprimir la información de ESE producto para ver el stock actualizado
Console.WriteLine($"Estado actualizado: {productoParaVender.ObtenerInfoCompleta()}");

Console.WriteLine("\n--- Intentando Vender Más de lo que Hay ---");
productoParaVender.Vender(10); // Intentamos vender 10, pero solo quedan 3 si vendimos 2

// 4. Mostrar el número total de productos distintos
Console.WriteLine($"\nActualmente hay {inventario.Count} tipos de productos diferentes en el inventario.");


Console.WriteLine("\nPresiona cualquier tecla para salir...");
Console.ReadKey();