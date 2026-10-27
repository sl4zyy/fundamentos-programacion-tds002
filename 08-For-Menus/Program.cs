/*
 * Nombre: Wilfre Mateo Medina
 * Fecha: 27/10/2026
 * Descripción: Menú con do-while y switch que muestra las tablas del
 * 1 al 10 con ciclos anidados o dibuja un triángulo de asteriscos.
 */

using System;

class Program
{
    static void Main(string[] args)
    {
        int opcion;

        do
        {
            Console.WriteLine();
            Console.WriteLine("===== MENÚ =====");
            Console.WriteLine("1. Tablas del 1 al 10");
            Console.WriteLine("2. Triángulo de asteriscos");
            Console.WriteLine("0. Salir");
            Console.Write("Opción: ");
            if (!int.TryParse(Console.ReadLine(), out opcion))
                opcion = -1;

            switch (opcion)
            {
                case 1:
                    MostrarTablas();
                    break;
                case 2:
                    DibujarTriangulo();
                    break;
                case 0:
                    Console.WriteLine("Hasta luego.");
                    break;
                default:
                    Console.WriteLine("Opción no válida.");
                    break;
            }
        } while (opcion != 0);
    }

    // Tablas del 1 al 10 con dos for anidados; cada valor ocupa 4 espacios
    static void MostrarTablas()
    {
        for (int fila = 1; fila <= 10; fila++)
        {
            for (int columna = 1; columna <= 10; columna++)
            {
                Console.Write($"{fila * columna,4}");
            }
            Console.WriteLine();
        }
    }

    // Triángulo de N filas: la fila i tiene i asteriscos
    static void DibujarTriangulo()
    {
        int n;
        Console.Write("Número de filas: ");
        while (!int.TryParse(Console.ReadLine(), out n) || n < 1)
        {
            Console.Write("Escribe un entero mayor que 0: ");
        }

        for (int i = 1; i <= n; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
}
