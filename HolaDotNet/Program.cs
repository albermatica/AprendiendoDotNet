using System;
using System.Collections.Generic; // Necesario para List<T>
using System.Text.Json;           // Necesario para JsonSerializer
using HolaDotNet;                 // Para poder usar tu clase Producto

namespace HolaDotNet // Asegúrate de que tu Program.cs esté dentro de este namespace
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- Lección 2.5: Serialización y Deserialización JSON ---");

            // --- 1. Crear un Producto y Serializarlo a JSON ---
            Console.WriteLine("\n--- Serializando un Producto a JSON ---");
            Producto miProductoOriginal = new Producto(101, "Smartphone Pro", 899.99, 15);

            // JsonSerializer.Serialize convierte el objeto C# en una cadena JSON
            // El segundo argumento 'new JsonSerializerOptions { WriteIndented = true }'
            // es opcional, pero hace que el JSON sea más legible (con indentación).
            string jsonDeProducto = JsonSerializer.Serialize(miProductoOriginal, new JsonSerializerOptions { WriteIndented = true });

            Console.WriteLine("Objeto C# 'miProductoOriginal' serializado a JSON:");
            Console.WriteLine(jsonDeProducto);

            // --- 2. Crear una Cadena JSON y Deserializarla a un Producto ---
            Console.WriteLine("\n--- Deserializando JSON a un Objeto Producto ---");

            // Esta es la cadena JSON que vamos a deserializar.
            // Nota las comillas dobles escapadas \" para las propiedades del JSON.
            string jsonRecibido = "{\"Id\":202,\"Nombre\":\"Smartwatch X\",\"Precio\":249.50,\"Stock\":30}";

            Console.WriteLine("Cadena JSON a deserializar:");
            Console.WriteLine(jsonRecibido);

            // JsonSerializer.Deserialize<Producto> convierte la cadena JSON en un objeto C# de tipo Producto
            Producto productoDeserializado = JsonSerializer.Deserialize<Producto>(jsonRecibido);

            Console.WriteLine("\nObjeto 'productoDeserializado' (desde JSON) verificado:");
            Console.WriteLine($"ID: {productoDeserializado.Id}");
            Console.WriteLine($"Nombre: {productoDeserializado.Nombre}");
            Console.WriteLine($"Precio: {productoDeserializado.Precio:C}"); // Usando formato de moneda
            Console.WriteLine($"Stock: {productoDeserializado.Stock}");


            // --- 3. BONUS: Serializar una List<Producto> ---
            Console.WriteLine("\n--- Serializando una Lista de Productos a JSON ---");

            List<Producto> listaDeProductos = new List<Producto>
            {
                new Producto(301, "Teclado Mecánico", 120.00, 25),
                new Producto(302, "Ratón Ergonómico", 45.00, 40),
                new Producto(303, "Webcam HD", 70.00, 18)
            };

            // Serializar la lista completa a JSON
            string jsonDeListaDeProductos = JsonSerializer.Serialize(listaDeProductos, new JsonSerializerOptions { WriteIndented = true });

            Console.WriteLine("Lista de objetos C# 'listaDeProductos' serializada a JSON:");
            Console.WriteLine(jsonDeListaDeProductos);

            Console.WriteLine("\nPresiona cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}