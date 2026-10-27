/*
 * Nombre: Wilfre Mateo Medina
 * Fecha: 27/10/2026
 * Descripción: Evaluación 05, programa 2. El usuario intenta adivinar
 * un número secreto del 1 al 100; se le dice si es mayor o menor.
 */

using System;

class Program
{
    static void Main(string[] args)
    {
        // Número secreto entre 1 y 100 (el 101 no se incluye)
        int secreto = Random.Shared.Next(1, 101);
        int intentos = 0; // contador
        int intento = 0;

        Console.WriteLine("Adivina el número secreto (1-100).");

        while (intento != secreto)
        {
            Console.Write("Tu intento: ");
            if (!int.TryParse(Console.ReadLine(), out intento))
            {
                Console.WriteLine("Escribe un número entero.");
                continue;
            }

            intentos++;

            if (intento < secreto)
                Console.WriteLine("El número secreto es mayor.");
            else if (intento > secreto)
                Console.WriteLine("El número secreto es menor.");
        }

        Console.WriteLine($"¡Correcto! Era el {secreto}. Lo lograste en {intentos} intentos.");
    }
}
