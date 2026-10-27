/*
 * Nombre: Wilfre Mateo Medina
 * Fecha: 27/10/2026
 * Descripción: Evaluación 03, programa 1. Calcula el salario bruto,
 * los descuentos de AFP y SFS y el salario neto de un empleado.
 */

using System;

class Program
{
    // Porcentajes de descuento de ley
    const double TASA_AFP = 0.0287;
    const double TASA_SFS = 0.0304;

    static void Main(string[] args)
    {
        // Entrada
        Console.Write("Nombre del empleado: ");
        string nombre = Console.ReadLine() ?? "";

        Console.Write("Horas trabajadas: ");
        double horas = double.Parse(Console.ReadLine() ?? "0");

        Console.Write("Pago por hora (RD$): ");
        double pagoHora = double.Parse(Console.ReadLine() ?? "0");

        // Proceso
        double bruto = horas * pagoHora;
        double afp = bruto * TASA_AFP;
        double sfs = bruto * TASA_SFS;
        double neto = bruto - afp - sfs;

        // Salida
        Console.WriteLine();
        Console.WriteLine("=========== NÓMINA ===========");
        Console.WriteLine($"Empleado: {nombre.ToUpper()}");
        Console.WriteLine($"Salario bruto: RD$ {bruto:N2}");
        Console.WriteLine($"AFP (2.87 %):  RD$ {afp:N2}");
        Console.WriteLine($"SFS (3.04 %):  RD$ {sfs:N2}");
        Console.WriteLine($"Salario neto:  RD$ {neto:N2}");
        Console.WriteLine("==============================");
    }
}
