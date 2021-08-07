using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculate_the_area_of_the_circles
{
    public class Circle
    {
        int radius;
        float area;

        public Circle(int radius)
        {
            this.radius = radius;
            area = (float)(Math.PI * Math.Pow(radius, 2));
        }
        public int Radius
        {
            get { return radius; }
        }

        public float Area
        {
            get { return area; }
        }


    }
}
