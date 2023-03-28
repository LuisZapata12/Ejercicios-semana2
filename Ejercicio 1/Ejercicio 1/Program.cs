using System;

namespace Ejercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Square square = new Square(15);
            float a;
            float b;
            string lectura;


            Figura fig = new Figura();
            rectangulo rec = new rectangulo(10,5);
            triangulo tri = new triangulo(5, 15);


            Console.WriteLine("ingrese (rectangulo) si quiere saber su area");
            Console.WriteLine("ingrese(triangulo) si quiere saber su area");
            Console.WriteLine("ingrese(cuadrado) si quiere saber su area");

            lectura = Console.ReadLine();


            if (lectura == "rectangulo")
            {
                Console.WriteLine($"Rectangulo: {rec.CalculateArea()}");
            }
            if (lectura == "triangulo")
            {
                Console.WriteLine($"triangulo: {tri.CalculateArea()}");
            }
            if (lectura == "circulo")
            
            {
                Console.WriteLine($"cuadrado : {square.CalculateArea()}");
            }


            Console.ReadLine();






            //Console.WriteLine($"triangulo: {tri.CalculateArea()}");

        }
       
    }
}
