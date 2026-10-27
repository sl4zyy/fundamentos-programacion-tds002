/*
 * Nombre: Wilfre Mateo Medina
 * Fecha: 27/10/2026
 * Descripción: Conversor de unidades. Pasa libras a kilogramos
 * y grados Fahrenheit a grados Celsius.
 */

using System;

class Program
{
    // Factor de conversión: 1 libra = 0.453592 kg
    const double KG_POR_LIBRA = 0.453592;

    static void Main(string[] args)
    {
        // Entrada
        Console.Write("Peso en libras: ");
        double libras = double.Parse(Console.ReadLine() ?? "0");

        Console.Write("Temperatura en °F: ");
        double fahrenheit = double.Parse(Console.ReadLine() ?? "0");

        // Proceso
        double kilogramos = libras * KG_POR_LIBRA;
        double celsius = (fahrenheit - 32) * 5 / 9;

        // Salida con dos decimales
        Console.WriteLine();
        Console.WriteLine($"{libras} lb equivalen a {kilogramos:F2} kg");
        Console.WriteLine($"{fahrenheit} °F equivalen a {Math.Round(celsius, 2)} °C");
    }
}
