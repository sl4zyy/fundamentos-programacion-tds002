/*
 * Nombre: Wilfre Mateo Medina
 * Fecha: 27/10/2026
 * Descripción: Evaluación 03, programa 3. Calcula área y circunferencia
 * de un círculo y la hipotenusa de un triángulo rectángulo.
 */

using System;

class Program
{
    static void Main(string[] args)
    {
        // Entrada
        Console.Write("Radio del círculo: ");
        double radio = double.Parse(Console.ReadLine() ?? "0");

        Console.Write("Cateto a: ");
        double catetoA = double.Parse(Console.ReadLine() ?? "0");

        Console.Write("Cateto b: ");
        double catetoB = double.Parse(Console.ReadLine() ?? "0");

        // Proceso con la clase Math
        double area = Math.PI * Math.Pow(radio, 2);
        double circunferencia = 2 * Math.PI * radio;
        double hipotenusa = Math.Sqrt(Math.Pow(catetoA, 2) + Math.Pow(catetoB, 2));

        // Salida con 2 decimales
        Console.WriteLine();
        Console.WriteLine($"Área del círculo:     {area:F2}");
        Console.WriteLine($"Circunferencia:       {circunferencia:F2}");
        Console.WriteLine($"Hipotenusa:           {hipotenusa:F2}");
    }
}
