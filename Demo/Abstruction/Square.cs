using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Abstruction
{
    internal class Square : Shape
    {
        public override double Perimeter
        {
            get { return Dim01 * 4; }
        }

        public override double Area()
        {
            return Dim01 * Dim01;
        }
    }
}
