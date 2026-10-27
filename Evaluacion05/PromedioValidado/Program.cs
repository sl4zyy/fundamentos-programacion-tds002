/*
 * Nombre: Wilfre Mateo Medina
 * Fecha: 27/10/2026
 * Descripción: Evaluación 05, programa 3. Pide notas válidas (0-100)
 * hasta escribir -1 y muestra el promedio, la nota mayor y la menor.
 */

using System;

class Program
{
    static void Main(string[] args)
    {
        int cantidad = 0;
        double suma = 0;
        double mayor = 0;
        double menor = 100;
        double nota;

        Console.WriteLine("Escribe notas entre 0 y 100. Escribe -1 para terminar.");

        do
        {
            // Validación: se repite hasta tener un número entre 0 y 100, o -1
            bool valida;
            do
            {
                Console.Write("Nota: ");
                valida = double.TryParse(Console.ReadLine(), out nota)
                         && (nota == -1 || (nota >= 0 && nota <= 100));
                if (!valida)
                    Console.WriteLine("Nota no válida, intenta de nuevo.");
            } while (!valida);

            if (nota != -1)
            {
                cantidad++;
                suma += nota;
                if (nota > mayor) mayor = nota;
                if (nota < menor) menor = nota;
            }
        } while (nota != -1);

        Console.WriteLine();
        if (cantidad > 0)
        {
            double promedio = suma / cantidad;
            Console.WriteLine($"Notas registradas: {cantidad}");
            Console.WriteLine($"Promedio:          {promedio:F2}");
            Console.WriteLine($"Nota mayor:        {mayor}");
            Console.WriteLine($"Nota menor:        {menor}");
        }
        else
        {
            Console.WriteLine("No se registraron notas.");
        }
    }
}
