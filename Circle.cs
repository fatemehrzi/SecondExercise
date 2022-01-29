using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondExercise
{
    class Circle : Shape
    {
        double Radius;
        const double Pi = 3.14;

        public Circle(double radius)
        {
            Radius = radius;
            const double Pi = 3.14;
        }
        public double GetArea()
        {
            Area = (Math.Pow(Radius, 2) * Pi);

            return Area;
        }
    }
}

