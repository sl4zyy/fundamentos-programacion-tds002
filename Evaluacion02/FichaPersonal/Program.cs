/*
 * Nombre: Wilfre Mateo Medina
 * Fecha: 27/10/2026
 * Descripción: Evaluación 02, programa 1. Pide datos personales y muestra
 * una ficha con interpolación y el año en que la persona cumplirá 30 años.
 */

using System;

class Program
{
    const int ANIO_ACTUAL = 2026;
    const int EDAD_META = 30;

    static void Main(string[] args)
    {
        // Entrada: un dato de cada tipo (string, int, double, bool)
        Console.Write("Nombre: ");
        string nombre = Console.ReadLine() ?? "";

        Console.Write("Edad: ");
        int edad = int.Parse(Console.ReadLine() ?? "0");

        Console.Write("Estatura en metros (ej. 1.75): ");
        double estatura = double.Parse(Console.ReadLine() ?? "0");

        Console.Write("¿Trabajas? (true/false): ");
        bool trabaja = bool.Parse(Console.ReadLine() ?? "false");

        // Proceso: año en que cumple 30 (si ya los cumplió, el resultado es un año pasado)
        int anioTreinta = ANIO_ACTUAL + (EDAD_META - edad);

        // Salida: ficha personal
        Console.WriteLine();
        Console.WriteLine("========== FICHA PERSONAL ==========");
        Console.WriteLine($"Nombre:    {nombre}");
        Console.WriteLine($"Edad:      {edad} años");
        Console.WriteLine($"Estatura:  {estatura} m");
        Console.WriteLine($"Trabaja:   {trabaja}");
        Console.WriteLine($"Cumple {EDAD_META} años en: {anioTreinta}");
        Console.WriteLine("====================================");
    }
}
