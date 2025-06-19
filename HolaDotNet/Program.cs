string nombre = "Alberto";
int edad = 34;
double salarioMensual = 34000;
bool esEmpleado = true;

// Calculamos salario anual
double salarioAnual = salarioMensual * 12;

//Calculamos ahorro neto

double ahorroNetos = salarioAnual - 5000;

// Años para jubilacion

int añosJubilacion = 65 - edad;

// Calculo si es mayor de edad

bool esMayorDeEdad = (edad >= 18);

//Calculo si puede solicitar credito

bool puedeSolicitarCredito = (esEmpleado && salarioMensual>=1500);

//Calcular si necesita aumento

bool necesitaAumento = (salarioAnual < 25000 || ahorroNetos < 1000);

Console.WriteLine("Tu salario anual es:" + salarioAnual);
Console.WriteLine("Tus ahorros netos son: " + ahorroNetos);
Console.WriteLine("Tus años para la jubilación son: " + añosJubilacion);
Console.WriteLine("¿Es mayor de edad? " + esMayorDeEdad);
Console.WriteLine("¿Puede solicitar crédito? " + puedeSolicitarCredito);
Console.WriteLine("¿Necesita aumento? " + necesitaAumento);



Console.WriteLine("\nPresiona cualquier tecla para salir...");
Console.ReadKey();