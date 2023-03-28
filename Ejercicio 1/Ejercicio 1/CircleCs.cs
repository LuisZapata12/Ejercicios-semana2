using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosSemana2
{
    class Circle
    {
        private float radius;

        public Circle(float radius)
        {
            this.radius = radius;
        }
        
        public float CalculateArea()
        {
            return(float) (radius * radius * 3.1416);
        }
        
        static void Main(string[] args)
        {
            Circle c1 = new Circle(2);
            Console.WriteLine("Si el radio es:" + c1.radius + ", entonces el área es:" + c1.CalculateArea());
        }
    }
}
