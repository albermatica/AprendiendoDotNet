string usuarioRegistrado = "admin";
string contraseñaRegistrada = "passwrod";
Console.Write("Ingrese su usuario: ");
string usuarioIngresado = Console.ReadLine();
Console.Write("Ingrese su usuario: ");
string contraseñaIngresada = Console.ReadLine();

if(usuarioIngresado == usuarioRegistrado && contraseñaIngresada == contraseñaRegistrada)
{
    Console.WriteLine("¡Acceso concedido! Bienvenido.");
}
else
{
    Console.WriteLine("¡Acceso incorrecto! Acceso denegado.");
}

Console.Write("Ingrese su edad: ");
int edad = int.Parse(Console.ReadLine());

if(edad >= 18)
{
    Console.WriteLine("Puedes acceder a contenido para adultos.");
}
else
{
    Console.WriteLine("Acceso restringido a contenido para adultos.");
}

Console.WriteLine("\nPresiona cualquier tecla para salir...");
Console.ReadKey();