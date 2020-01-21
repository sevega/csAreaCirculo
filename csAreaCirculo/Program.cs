using System;

namespace csAreaCirculo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declaración de variables
            double area;
            int radio = 5;
            const double pi = 3.1416;
            // Proceso
            area = pi * (radio * 2);
            // Salida de datos
            Console.WriteLine($"El área del circulo es de {area}" +
                $" tomando como radio un valor de {radio}");

        }
    }
}
