using System;

namespace Ejercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Figura fig = new Figura();
            rectangulo rec = new rectangulo(10, 5);
              


            Console.WriteLine($"figura: {fig.CalculateArea()}");
            Console.WriteLine($"Rectangulo: {rec.CalculateArea()}");
        }
    }
}
