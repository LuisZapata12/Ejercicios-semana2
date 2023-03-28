using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio_1
{
    class Square : Figura
    {
        private float side;

        public Square(float side)
        {
            this.side = side;
        }

        public override float CalculateArea()
        {
            return side * side;
        }
    }
}
