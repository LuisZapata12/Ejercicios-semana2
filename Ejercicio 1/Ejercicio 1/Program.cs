using System;

namespace Ejercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            float a;
            float b;


            Console.WriteLine("Inserte la altura del rectangulo");
            a = float.Parse(Console.ReadLine());

            Console.WriteLine("Inserte la base del rectangulo");
            b = float.Parse(Console.ReadLine());

            Figura fig = new Figura();
            rectangulo rec = new rectangulo(a, b);
            triangulo tri = new triangulo(a,b);
             
            Console.WriteLine($"figura: {fig.CalculateArea()}");

            Console.WriteLine($"Rectangulo: {rec.CalculateArea()}");
            Console.WriteLine();
          
            




            
            //Console.WriteLine($"triangulo: {tri.CalculateArea()}");

        }
       
    }
}
