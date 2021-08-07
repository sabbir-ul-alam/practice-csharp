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
            const float PI = (float)Math.PI;
            for (radius = 0; radius <= 5; radius++)
            {
                area = PI * (float)Math.Pow(radius, 2);
                Console.WriteLine("Radius: {0},  Area: {1,5:N2}",radius,area);
            }
        }
    }
}
