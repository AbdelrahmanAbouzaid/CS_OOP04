using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Demo.OperatorOverloading
{
    internal class Complex
    {
        public int Real { get; set; }
        public int Imag { get; set; }

        //Must be Static Member Function
        //Can't overload [] or =

        //Can't Explicitly Overload Compund Operators (+= , -= , *= , .....)
        //if you overload Original Operator (+) , Compund Operator will be supported by default

        public static Complex operator +(Complex left, Complex right)
        {
            return new Complex()
            {
                Real = (left?.Real ?? 0) + (right.Real),
                Imag = (left?.Imag ?? 0) + (right.Imag)
            };
        }
        public static Complex operator -(Complex left, Complex right)
        {
            return new Complex()
            {
                Real = (left?.Real ?? 0) - (right.Real),
                Imag = (left?.Imag ?? 0) - (right.Imag)
            };
        }

        public static Complex operator ++(Complex complex)
        {
            return new Complex()
            {
                Real = (complex?.Real ?? 0) + 1,
                Imag = complex?.Imag ?? 0
            };
        }
        public static Complex operator --(Complex complex)
        {
            return new Complex()
            {
                Real = (complex?.Real ?? 0) - 1,
                Imag = complex?.Imag ?? 0
            };
        }

        public static bool operator >(Complex left, Complex right)
        {
            if (left.Real == right.Real)
                return left.Imag > right.Imag;
            return left.Real > right.Real;
        }
        public static bool operator <(Complex left, Complex right)
        {
            if (left.Real == right.Real)
                return left.Imag < right.Imag;
            return left.Real < right.Real;
        }
        public static bool operator >=(Complex left, Complex right)
        {
            if (left.Real == right.Real)
                return left.Imag >= right.Imag;
            return left.Real >= right.Real;
        }
        public static bool operator <=(Complex left, Complex right)
        {
            if (left.Real == right.Real)
                return left.Imag <= right.Imag;
            return left.Real <= right.Real;
        }

        public static bool operator ==(Complex left, Complex right)
        {
            return left.Real == right.Real && left.Imag == right.Imag;
        }
        public static bool operator !=(Complex left, Complex right)
        {
            return left.Real != right.Real || left.Imag != right.Imag;
        }

        public static explicit operator string(Complex value)
        {
            return value.ToString();
        }
        public static implicit operator int(Complex value)
        {
            return value.Real;
        }
        public override string ToString()
        {
            return $" {Real} + {Imag} i";
        }
    }
}
