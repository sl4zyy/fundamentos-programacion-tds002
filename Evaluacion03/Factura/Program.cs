/*
 * Nombre: Wilfre Mateo Medina
 * Fecha: 27/10/2026
 * Descripción: Evaluación 03, programa 2. Genera una factura simple
 * con subtotal, ITBIS (18 %) y total en columnas alineadas.
 */

using System;

class Program
{
    const double TASA_ITBIS = 0.18;

    static void Main(string[] args)
    {
        // Entrada
        Console.Write("Producto: ");
        string producto = Console.ReadLine() ?? "";

        Console.Write("Cantidad: ");
        int cantidad = int.Parse(Console.ReadLine() ?? "0");

        Console.Write("Precio unitario (RD$): ");
        double precio = double.Parse(Console.ReadLine() ?? "0");

        // Proceso
        double subtotal = cantidad * precio;
        double itbis = subtotal * TASA_ITBIS;
        double total = subtotal + itbis;

        // Salida en columnas: etiquetas a la izquierda, montos a la derecha
        Console.WriteLine();
        Console.WriteLine("================ FACTURA ================");
        Console.WriteLine($"{"Producto",-20}{"Cant.",6}{"Precio",14}");
        Console.WriteLine($"{producto,-20}{cantidad,6}{precio,14:N2}");
        Console.WriteLine("-----------------------------------------");
        Console.WriteLine("Subtotal:".PadRight(26) + $"{subtotal,14:N2}");
        Console.WriteLine("ITBIS (18 %):".PadRight(26) + $"{itbis,14:N2}");
        Console.WriteLine("TOTAL:".PadRight(26) + $"{total,14:N2}");
        Console.WriteLine("=========================================");
    }
}
