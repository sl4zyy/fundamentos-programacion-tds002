/*
 * Nombre: Wilfre Mateo Medina
 * Fecha: 27/10/2026
 * Descripción: Parte 1 convierte una nota (0-100) a letra con if/else if.
 * Parte 2 es una calculadora de cuatro operaciones con switch.
 */

using System;

class Program
{
    static void Main(string[] args)
    {
        // ---------- Parte 1: Calificación ----------
        Console.Write("Escribe una nota (0-100): ");
        string entrada = Console.ReadLine() ?? "";

        // TryParse evita que el programa se caiga si no escriben un número
        if (int.TryParse(entrada, out int nota) && nota >= 0 && nota <= 100)
        {
            string letra;
            if (nota >= 90)
                letra = "A";
            else if (nota >= 80)
                letra = "B";
            else if (nota >= 70)
                letra = "C";
            else
                letra = "F";

            Console.WriteLine($"Tu calificación es: {letra}");
        }
        else
        {
            Console.WriteLine("Nota no válida. Debe ser un número entero entre 0 y 100.");
        }

        Console.WriteLine();

        // ---------- Parte 2: Calculadora ----------
        Console.Write("Primer número: ");
        double a = double.Parse(Console.ReadLine() ?? "0");

        Console.Write("Segundo número: ");
        double b = double.Parse(Console.ReadLine() ?? "0");

        Console.WriteLine("1. Sumar  2. Restar  3. Multiplicar  4. Dividir");
        Console.Write("Elige una opción: ");
        int opcion = int.Parse(Console.ReadLine() ?? "0");

        switch (opcion)
        {
            case 1:
                Console.WriteLine($"{a} + {b} = {a + b}");
                break;
            case 2:
                Console.WriteLine($"{a} - {b} = {a - b}");
                break;
            case 3:
                Console.WriteLine($"{a} * {b} = {a * b}");
                break;
            case 4:
                if (b == 0)
                    Console.WriteLine("No se puede dividir entre cero.");
                else
                    Console.WriteLine($"{a} / {b} = {a / b:F2}");
                break;
            default:
                Console.WriteLine("Opción no válida.");
                break;
        }
    }
}
