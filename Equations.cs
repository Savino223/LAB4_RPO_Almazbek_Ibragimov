using System;
using Inter;
using Equation_Bases;
using solvers;
using Comp;

namespace Equations
{
    public static class Equationss
    {

        public static double[] RemoveCoefs(double[] coeffs)
        {
            int lastInd = coeffs.Length - 1;
            while (lastInd >= 0 && coeffs[lastInd] == 0)
            {
                lastInd--;
            }
            if (lastInd == coeffs.Length - 1)
            {
                return coeffs;
            }
            double[] res = new double[lastInd + 1];
            Array.Copy(coeffs, res, lastInd + 1);
            return res;
        }


        public static IStrat SelectStrat(double[] coefficients)
        {
            int d = coefficients.Length;

            if (d == 0)
            {
                throw new InvalidOperationException("Несуществующий вид уравнений");
            }

            if (d == 2)
            {
                return new Linear();
            }

            if (d == 3)
            {
                return new Quadr();
            }

            throw new InvalidOperationException("Несуществующий вид уравнений");
        }

        public static IEquation Create(double[] coeffs)
        {
            coeffs = RemoveCoefs(coeffs);
            return new Equation(coeffs);
        }

    }
}