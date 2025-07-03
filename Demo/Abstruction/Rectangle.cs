using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Abstruction
{
    internal class Rectangle : Shape
    {
        public override double Perimeter
        {
            get { return (Dim01 + Dim02) * 2; }
        }

        public override double Area()
        {
            return Dim01 * Dim02;
        }
    }
}
