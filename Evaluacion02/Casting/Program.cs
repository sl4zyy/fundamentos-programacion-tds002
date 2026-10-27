/*
 * Nombre: Wilfre Mateo Medina
 * Fecha: 27/10/2026
 * Descripción: Evaluación 02, programa 3. Demuestra casting explícito
 * (double a int) y casting implícito (int a double).
 */

using System;

class Program
{
    static void Main(string[] args)
    {
        // Entrada: número con decimales
        Console.Write("Escribe un número con decimales (ej. 7.85): ");
        double numeroDecimal = double.Parse(Console.ReadLine() ?? "0");

        // Casting explícito: se corta la parte decimal (no redondea)
        int parteEntera = (int)numeroDecimal;

        // Casting implícito: un int cabe en un double sin perder datos
        int numeroEntero = parteEntera;
        double comoDouble = numeroEntero;

        // Salida
        Console.WriteLine($"Número original:            {numeroDecimal}");
        Console.WriteLine($"Parte entera ((int)):       {parteEntera}");
        Console.WriteLine($"Implícito int -> double:    {comoDouble} (tipo {comoDouble.GetType().Name})");
    }
}
