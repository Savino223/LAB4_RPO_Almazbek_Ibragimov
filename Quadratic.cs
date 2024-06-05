using Comp;
using System;

namespace solvers
{
    public class Quadr : IStrat
    {
        public Complex[] FindRoots(double[] coefficients)
        {
            double a = coefficients[0];
            double b = coefficients[1];
            double c = coefficients[2];

            double d = b * b - 4 * a * c;

            if (d < 0)
            {
                throw new InvalidOperationException("дискриминат равен нулю");
            }

            double koren_d = Math.Sqrt(d);
            double r1 = (-1 * b + koren_d) / (2 * a);
            double r2 = (-1 * b - koren_d) / (2 * a);

            return new Complex[] { new Complex(r1), new Complex(r2) };
        }
    }
}