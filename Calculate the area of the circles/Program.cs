using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculate_the_area_of_the_circles
{
    class Program
    {
        static void Main(string[] args)
        {
            int radius;
            float area;
            
            for (radius = 0; radius <= 5; radius++) {
                Circle circle = new Circle(radius);
                Console.WriteLine("Radius: {0}, Area: {1,5:N2}",circle.Radius, circle.Area);


            }

        }
    }
}
