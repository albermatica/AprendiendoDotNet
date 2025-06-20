using HolaDotNet;

Producto miPrimerProducto = new Producto(1, "Laptop Gamer", 1200.00, 5);
Producto miSegundoProducto = new Producto(2, "Monitor Ultrawide", 360.00, 3);

Console.WriteLine($"Producto 1: {miPrimerProducto.Nombre}, Precio: {miPrimerProducto.Precio}, Stock: {miPrimerProducto.Stock}");
Console.WriteLine($"Producto 2: {miSegundoProducto.Nombre}, Precio: {miSegundoProducto.Precio}, Stock: {miSegundoProducto.Stock}");

Console.WriteLine("\nPresiona cualquier tecla para salir...");
Console.ReadKey();
