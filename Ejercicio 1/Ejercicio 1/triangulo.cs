using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio_1
{
    class triangulo: Figura
    {
        private float b;
        private float a;
        

        public triangulo(float a ,float  b)
        {
            this.a = a;
            this.b = b;
        }
        public override float CalculateArea()
        {
            return a * b / 2;
        }
    }
}
