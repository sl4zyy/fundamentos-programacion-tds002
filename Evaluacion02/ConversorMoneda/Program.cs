/*
 * Nombre: Wilfre Mateo Medina
 * Fecha: 27/10/2026
 * Descripción: Evaluación 02, programa 2. Convierte un monto en pesos
 * dominicanos a dólares usando una tasa constante.
 */

using System;

class Program
{
    // Tasa de referencia del día (RD$ por 1 US$). Actualizar si cambia.
    const double TASA_USD = 63.50;

    static void Main(string[] args)
    {
        // Entrada: monto en pesos
        Console.Write("Monto en pesos (RD$): ");
        double montoPesos = double.Parse(Console.ReadLine() ?? "0");

        // Proceso: dividir entre la tasa para obtener dólares
        double montoDolares = montoPesos / TASA_USD;

        // Salida
        Console.WriteLine($"Tasa usada: RD${TASA_USD} por US$1");
        Console.WriteLine($"RD${montoPesos:N2} equivalen a US${montoDolares:N2}");
    }
}
