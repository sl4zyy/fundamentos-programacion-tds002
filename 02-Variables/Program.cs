/*
 * Nombre: Wilfre Mateo Medina
 * Fecha: 27/10/2026
 * Descripción: Pide nombre, edad y estatura, calcula el año de nacimiento
 * con la constante ANIO_ACTUAL y muestra todo con interpolación.
 */

using System;

class Program
{
    // Año de referencia para calcular el año de nacimiento
    const int ANIO_ACTUAL = 2026;

    static void Main(string[] args)
    {
        // Entrada de datos
        Console.Write("Escribe tu nombre: ");
        string nombre = Console.ReadLine() ?? "";

        Console.Write("Escribe tu edad: ");
        int edad = int.Parse(Console.ReadLine() ?? "0");

        Console.Write("Escribe tu estatura en metros (ej. 1.75): ");
        double estatura = double.Parse(Console.ReadLine() ?? "0");

        // Proceso: año aproximado de nacimiento
        int anioNacimiento = ANIO_ACTUAL - edad;

        // Salida con interpolación
        Console.WriteLine();
        Console.WriteLine($"Hola, {nombre}.");
        Console.WriteLine($"Tienes {edad} años y mides {estatura} m.");
        Console.WriteLine($"Naciste aproximadamente en el año {anioNacimiento}.");
    }
}
