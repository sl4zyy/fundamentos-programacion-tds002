/*
 * Nombre: Wilfre Mateo Medina
 * Fecha: 27/10/2026
 * Descripción: Lee dos enteros y muestra suma, resta, producto,
 * división real, división entera, residuo y si el primero es par.
 */

using System;

class Program
{
    static void Main(string[] args)
    {
        // Entrada
        Console.Write("Primer número entero: ");
        int x = int.Parse(Console.ReadLine() ?? "0");

        Console.Write("Segundo número entero: ");
        int y = int.Parse(Console.ReadLine() ?? "0");

        // Proceso con operadores aritméticos y relacionales
        int suma = x + y;
        int resta = x - y;
        int producto = x * y;
        bool esPar = x % 2 == 0;

        // Salida
        Console.WriteLine($"Suma:            {suma}");
        Console.WriteLine($"Resta:           {resta}");
        Console.WriteLine($"Producto:        {producto}");

        // Se evita dividir entre cero
        if (y != 0)
        {
            double divisionReal = (double)x / y;
            int divisionEntera = x / y;
            int residuo = x % y;
            Console.WriteLine($"División real:   {divisionReal:F2}");
            Console.WriteLine($"División entera: {divisionEntera}");
            Console.WriteLine($"Residuo:         {residuo}");
        }
        else
        {
            Console.WriteLine("No se puede dividir entre cero.");
        }

        Console.WriteLine($"¿{x} es par?:    {esPar}");
    }
}

/*
 * Prueba de escritorio (x = 10, y = 3)
 *
 * | Expresión       | Cálculo        | Resultado |
 * |-----------------|----------------|-----------|
 * | x + y           | 10 + 3         | 13        |
 * | x - y           | 10 - 3         | 7         |
 * | x * y           | 10 * 3         | 30        |
 * | (double)x / y   | 10.0 / 3       | 3.33      |
 * | x / y           | 10 / 3 (int)   | 3         |
 * | x % y           | 10 mod 3       | 1         |
 * | x % 2 == 0      | 10 % 2 = 0     | True      |
 */
