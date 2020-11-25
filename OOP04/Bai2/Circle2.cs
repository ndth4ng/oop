using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2
{
    class Circle2 : IShape
    {
        private double r;

        public double R { get => r; set => r = value; }

        public Circle2(double _r)
        {
            r = _r;
        }

        public Circle2() : this(0) { }

        public void Area()
        {
            Console.WriteLine("Dien tich: " + 3.14 * r * r);
        } 
    }
}
