using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Abstruction
{
    // Abstruct Class : Partial Class [Not Fully Implemented Class]
    // Concrete Class : Fully Implemented Class
    abstract class Shape
    {
        public double Dim01 { get; set; }
        public double Dim02 { get; set; }

        //Abstruct Method
        public abstract double Area();

        //Abstruct Properity
        public abstract double Perimeter { get; }
    }
}
