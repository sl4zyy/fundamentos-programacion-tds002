/*
 * Nombre: Wilfre Mateo Medina
 * Fecha: 12/09/2026
 * Descripción: Programa de consola que imprime una tarjeta de presentación
 * con nombre, matrícula, carrera y una frase personal, enmarcada con
 * caracteres (*, =, |).
 */

using System;

class Program
{
    static void Main(string[] args)
    {
        // Datos de la tarjeta de presentación
        string nombre = "Wilfre Mateo Medina";
        string matricula = "2026-0718";
        string carrera = "Tecnólogo en Ciberseguridad";
        string frase = "Aprendiendo a proteger lo que otros ignoran";

        // Se agrupan las líneas para calcular el ancho del marco según el texto más largo
        string[] lineas =
        {
            $"Nombre: {nombre}",
            $"Matrícula: {matricula}",
            $"Carrera: {carrera}",
            $"\"{frase}\""
        };

        int maxLen = 0;
        foreach (string linea in lineas)
        {
            if (linea.Length > maxLen) maxLen = linea.Length;
        }

        // Construcción del marco con los caracteres pedidos (*, =, |)
        string borde = new string('=', maxLen + 2);

        Console.WriteLine(new string('*', maxLen + 4));
        Console.WriteLine("*" + borde + "*");
        foreach (string linea in lineas)
        {
            Console.WriteLine("| " + linea.PadRight(maxLen) + " |");
        }
        Console.WriteLine("*" + borde + "*");
        Console.WriteLine(new string('*', maxLen + 4));
    }
}
