double numero1 = 0; // Inicializar para asegurar que tienen un valor por defecto
double numero2 = 0;
double resultadoDivision;

bool esNumero1Valido = false; // Usamos banderas separadas para cada número
do
{
    Console.Write("Escribe el primer número: ");
    try
    {
        numero1 = double.Parse(Console.ReadLine()); // <-- ¡CORREGIDO: double.Parse!
        esNumero1Valido = true;
    }
    catch (FormatException)
    {
        Console.WriteLine("Error: Por favor, ingrese un NÚMERO válido."); // <-- typo corregido
    }
    catch (Exception ex) // Para capturar cualquier otro error inesperado en la entrada
    {
        Console.WriteLine($"Ocurrió un error inesperado al leer el primer número: {ex.Message}");
    }
} while (!esNumero1Valido);

bool esNumero2Valido = false; // Reiniciamos la bandera para el segundo bucle
do
{
    Console.Write("Escribe el segundo número: ");
    try
    {
        numero2 = double.Parse(Console.ReadLine()); // <-- ¡CORREGIDO: double.Parse!
        esNumero2Valido = true;
    }
    catch (FormatException)
    {
        Console.WriteLine("Error: Por favor, ingrese un NÚMERO válido.");
    }
    catch (Exception ex) // Para capturar cualquier otro error inesperado en la entrada
    {
        Console.WriteLine($"Ocurrió un error inesperado al leer el segundo número: {ex.Message}");
    }
} while (!esNumero2Valido);

// --- BLOQUE DE DIVISIÓN CON SU PROPIO TRY-CATCH ---
try
{
    // Aquí es donde puede ocurrir la DivideByZeroException
    resultadoDivision = numero1 / numero2;
    Console.WriteLine($"El resultado de la división es: {resultadoDivision}");
}
catch (DivideByZeroException) // Capturamos la excepción específica de división por cero
{
    Console.WriteLine("Error: No se puede dividir por cero. Por favor, ingrese un segundo número diferente de cero.");
}
catch (Exception ex) // Capturamos cualquier otro error inesperado durante la división
{
    Console.WriteLine($"Ocurrió un error inesperado durante la división: {ex.Message}");
}
finally
{
    Console.WriteLine("Operación de división finalizada."); // Se ejecuta siempre
}

Console.WriteLine("\nPresiona cualquier tecla para salir...");
Console.ReadKey();