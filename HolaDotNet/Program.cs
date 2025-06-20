using HolaDotNet;

Producto miPrimerProducto = new Producto(1, "Laptop Gamer", 1200.00, 5);
Producto miSegundoProducto = new Producto(2, "Monitor Ultrawide", 360.00, 3);

Console.WriteLine(miPrimerProducto.ObtenerInfoCompleta());
Console.WriteLine(miSegundoProducto.ObtenerInfoCompleta());

Console.WriteLine("\n --- Simulación de Ventas ---");
miPrimerProducto.Vender(2);
Console.WriteLine(miPrimerProducto.ObtenerInfoCompleta());

Console.WriteLine();

miSegundoProducto.Vender(5); // Intenta vender 5 unidades
Console.WriteLine(miSegundoProducto.ObtenerInfoCompleta());

Console.WriteLine("\nPresiona cualquier tecla para salir...");
Console.ReadKey();
