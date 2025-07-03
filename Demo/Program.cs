using Demo.Abstruction;
using Demo.OperatorOverloading;

namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Abstruction
            // Abstruction
            // abstruct : c# Keyword [class - method - properties]

            //Shape shape = new Shape();
            // Can Not Create Object From Abstruct Class

            //Rectangle rectangle = new Rectangle() { Dim01 = 3, Dim02 = 5 };
            //Console.WriteLine(rectangle.Perimeter);
            //Console.WriteLine(rectangle.Area()); 
            #endregion

            #region Operator Overloading
            //// Operator Overloading

            //Complex c01 = new Complex() { Real = 3, Imag = 4 };
            //Complex c02 = new Complex() { Real = 2, Imag = 5 };

            //Complex c03 = c01 + c02;
            //Complex c04 = c02 - c03;

            //c01++;
            //c02--;

            //string str = (string)c01;
            //int x = c02;

            //Console.WriteLine(c01);
            //Console.WriteLine(c02);
            //Console.WriteLine(c03);
            //Console.WriteLine(c04); 
            #endregion


        }
    }
}
