using HolaDotNet;

Producto miPrimerProducto = new Producto();
miPrimerProducto.Id = 1;
miPrimerProducto.Nombre = "Laptop Gamer";
miPrimerProducto.Precio = 1200.00;
miPrimerProducto.Stock = 5;

Producto miSegundoProducto = new Producto();
miSegundoProducto.Id = 2;
miSegundoProducto.Nombre = "Monitor Ultrawide";
miSegundoProducto.Precio = 3600.00;
miSegundoProducto.Stock = 3;

Console.WriteLine("Producto: " + miPrimerProducto.Nombre);
Console.WriteLine("Precio: " + miPrimerProducto.Precio);

Console.WriteLine("Producto 2: " + miSegundoProducto.Nombre);
Console.WriteLine("Precio 2: " + miSegundoProducto.Precio);

Console.WriteLine("\nPresiona cualquier tecla para salir...");
Console.ReadKey();