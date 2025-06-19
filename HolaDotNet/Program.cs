using HolaDotNet;

Producto miPrimerProducto = new Producto();
miPrimerProducto.Id = 1;
miPrimerProducto.Nombre = "Laptop Gamer";
miPrimerProducto.Precio = 1200.00;
miPrimerProducto.Stock = 5;

Producto MiSegundoProducto = new Producto();
MiSegundoProducto.Id = 2;
MiSegundoProducto.Nombre = "Monitor Ultrawide";
MiSegundoProducto.Precio = 3600.00;
MiSegundoProducto.Stock = 3;

Console.WriteLine("Producto: " + miPrimerProducto.Nombre);
Console.WriteLine("Precio: " + miPrimerProducto.Precio);

Console.WriteLine("\nPresiona cualquier tecla para salir...");
Console.ReadKey();