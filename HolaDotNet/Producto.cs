using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HolaDotNet
{
    internal class Producto
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public double Precio { get; set; }
        public int Stock { get; set; }

       public Producto(int id, string nombre, double precio,int stock)
        {
            Id = id;
            Nombre = nombre;
            Precio = precio;
            Stock = stock;
        }

        public void Vender(int cantidad)
        {
            if (cantidad <= Stock) // Usamos 'Stock' que es una propiedad de este mismo objeto Producto
            {
                Stock -= cantidad; // Reducimos el stock
                Console.WriteLine($"Se vendieron {cantidad} unidades de {Nombre}. Nuevo stock: {Stock}");
            }
            else
            {
                Console.WriteLine($"No hay suficiente stock de {Nombre} para vender {cantidad} unidades. Stock actual: {Stock}");
            }
        }
        public string ObtenerInfoCompleta()
        {
            // Usamos interpolación de strings para construir el texto de forma legible
            return $"ID: {Id}, Nombre: {Nombre}, Precio: {Precio:C}, Stock: {Stock} unidades.";
            // Nota: El ":C" después de {Precio} es un "formato de moneda"
            // Puede que en tu sistema salga con el símbolo de €, $ o tu moneda local.
            // Si prefieres solo el número, quítale el ":C".
        }
    }
}
