using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG2070Assign1
{
    public class Circle
    {
        private int radius;

        public Circle()
        {
            radius = 1;
        }

        public Circle(int radius)
        {
            this.radius = radius;
        }

        public int GetRadius()
        {
            return radius;
        }

        public void SetRadius(int radius)
        {
            this.radius = radius;
        }

        public double GetCircumference()
        {

            return 2*Math.PI*radius;
        }

        public double GetArea()
        {
            return Math.PI * radius * radius;
        }
    }
}
