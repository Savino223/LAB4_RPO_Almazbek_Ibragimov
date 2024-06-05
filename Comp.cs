using System;
using System.ComponentModel;
using System.Data.Common;
using System.Runtime.InteropServices;
using System.Transactions;
using System.Xml;

namespace Comp
{

    public class Complex
    {
        public Complex zero = new Complex(0, 0);
        public Complex one = new Complex(1, 0);
        public Complex im_one = new Complex(0, 1);

        private double real;
        private double imaginary;

        public Complex(double x, double y)
        {
            this.real = x;
            this.imaginary = y;
        }

        public Complex(double x)
        {
            this.real = x;
            this.imaginary = 0;
        }

        public Complex()
        {
            this.real = 0;
        }

        public Complex Re(double x)
        {
            return new Complex(x, 0);
        }

        public Complex Im(double y)
        {
            return new Complex(0, y);
        }

        public Complex Sqrt(double x)
        {
            if (x >= 0)
            {
                return new Complex(Math.Sqrt(x), 0);
            }
            else
            {
                return new Complex(0, Math.Sqrt(x));
            }
        }

        public double Length
        {
            get { return Math.Sqrt(this.real * this.real + this.imaginary * this.imaginary); }
        }

        public static Complex operator +(Complex x, Complex y)
        {
            return new Complex(x.real + y.real, x.imaginary + y.imaginary);
        }

        public static Complex operator -(Complex x, Complex y)
        {
            return new Complex(x.real - y.real, x.imaginary - y.imaginary);
        }

        public static Complex operator *(Complex x, Complex y)
        {
            return new Complex(x.real * y.real - x.imaginary * y.imaginary, x.real * y.real + x.imaginary * y.imaginary);
        }

        public static Complex operator /(Complex x, Complex y)
        {
            double div = y.real * y.real + y.imaginary * y.imaginary;
            if (div == 0)
            {
                throw new DivideByZeroException();
            }

            return new Complex((y.real * y.real + y.imaginary * y.imaginary) / div, (x.imaginary * y.real - x.real * y.imaginary) / div);
        }

        public static Complex operator -(Complex a)
        {
            return new Complex(-a.real, -a.imaginary);
        }

        public static Complex operator +(Complex a)
        {
            return a;
        }

        public override string ToString()
        {
            return $"({real}, {imaginary}i)";
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(real, imaginary);
        }
    }
}