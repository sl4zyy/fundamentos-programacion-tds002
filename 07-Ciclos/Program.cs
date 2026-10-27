/*
 * Nombre: Wilfre Mateo Medina
 * Fecha: 27/10/2026
 * Descripción: Valida un número del 1 al 12 con do-while, muestra su
 * tabla de multiplicar con while y suma todos los resultados.
 */

using System;

class Program
{
    static void Main(string[] args)
    {
        int numero;

        // 1. Validación con do-while: se repite hasta que el número esté entre 1 y 12
        do
        {
            Console.Write("Escribe un número entre 1 y 12: ");
            if (!int.TryParse(Console.ReadLine(), out numero))
                numero = 0;

            if (numero < 1 || numero > 12)
                Console.WriteLine("Número no válido, intenta de nuevo.");
        } while (numero < 1 || numero > 12);

        // 2. Tabla de multiplicar con while y un contador
        int contador = 1;
        int suma = 0; // acumulador

        Console.WriteLine($"\nTabla del {numero}:");
        while (contador <= 12)
        {
            int resultado = numero * contador;
            Console.WriteLine($"{numero} x {contador} = {resultado}");
            suma += resultado;
            contador++;
        }

        // 3. Suma de todos los resultados
        Console.WriteLine($"\nSuma de todos los resultados: {suma}");
    }
}
