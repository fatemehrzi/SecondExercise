using System;

namespace SecondExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Select a shape: Rectangle, Circle");
            var shape=Console.ReadLine();
            if (shape == "Circle") 
            {
                Console.WriteLine("Enter Radius between 1 and 100");
                var radius = Convert.ToDouble(Console.ReadLine());
                var obj1 = new Circle(radius);
                var S = obj1.GetArea();
                Console.WriteLine($"Area={S}");
            }
            else if (shape == "Rectangle")
            {
                Console.WriteLine("Enter Length between 1 and 100");
                var Length = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter Width between 1 and 100");
                var Width = Convert.ToDouble(Console.ReadLine());
                var obj2 = new Rectangle(Length, Width);
                var S = obj2.GetArea();
                Console.WriteLine($"Area={S}");
            }
            
            Console.ReadKey();
        }
    }
}
