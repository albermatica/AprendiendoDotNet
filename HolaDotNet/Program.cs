int edad = 0; // Inicializamos la edad fuera del try para que sea accesible
bool edadValida = false;

do
{
    Console.Write("Ingrese su edad: ");
    try
    {
        edad = int.Parse(Console.ReadLine());
        edadValida = true; // Si la conversión es exitosa, la edad es válida
    }
    catch (FormatException) // Captura el error si el texto no es un número
    {
        Console.WriteLine("¡Error! Por favor, ingrese un NÚMERO válido para su edad.");
    }
    catch (OverflowException) // Captura si el número es demasiado grande o pequeño para un int
    {
        Console.WriteLine("¡Error! El número ingresado es demasiado grande o pequeño.");
    }
    catch (Exception ex) // Captura cualquier otro error inesperado
    {
        Console.WriteLine($"Ocurrió un error inesperado: {ex.Message}");
    }
} while (!edadValida); // Repite el bucle hasta que la edad sea válida

// Aquí puedes usar la variable 'edad' de forma segura
if (edad >= 18)
{
    Console.WriteLine("Puedes acceder a contenido para adultos.");
}
else
{
    Console.WriteLine("Acceso restringido a contenido para adultos.");
}