using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondExercise
{
    class Rectangle : Shape
    {
        double Length;



        double Width;

        public Rectangle(double Length, double Width)
        {
            this.Length = Length;
            this.Width = Width;
        }

        public new double GetArea()
        {  
                Area = Length * Width;
                return Area;

        }
    }
}
