/*
 * Nombre: Wilfre Mateo Medina
 * Fecha: 27/10/2026
 * Descripción: Evaluación 05, programa 1. Lee precios hasta que se
 * escriba 0 y muestra cantidad de productos, subtotal, ITBIS y total.
 */

using System;

class Program
{
    const double TASA_ITBIS = 0.18;

    static void Main(string[] args)
    {
        int cantidadProductos = 0; // contador
        double subtotal = 0;       // acumulador
        double precio;

        Console.WriteLine("Escribe los precios uno por uno. Escribe 0 para terminar.");

        do
        {
            Console.Write("Precio: ");
            if (!double.TryParse(Console.ReadLine(), out precio) || precio < 0)
            {
                Console.WriteLine("Precio no válido, intenta de nuevo.");
                precio = -1; // valor que no termina el ciclo ni se suma
            }
            else if (precio > 0)
            {
                cantidadProductos++;
                subtotal += precio;
            }
        } while (precio != 0);

        double itbis = subtotal * TASA_ITBIS;
        double total = subtotal + itbis;

        Console.WriteLine();
        Console.WriteLine($"Productos:    {cantidadProductos}");
        Console.WriteLine($"Subtotal:     RD$ {subtotal:N2}");
        Console.WriteLine($"ITBIS (18 %): RD$ {itbis:N2}");
        Console.WriteLine($"Total:        RD$ {total:N2}");
    }
}
