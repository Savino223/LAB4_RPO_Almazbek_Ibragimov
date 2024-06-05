using System;
using Inter;
using Comp;

namespace solvers
{

    public class Linear : IStrat
    {
        Complex[] IStrat.FindRoots(double[] coeffs)
        {
            if (coeffs[0] == 0)
            {
                throw new InvalidOperationException("Коэфициент а не может быть 0!");
            }

            double root = -coeffs[1] / coeffs[0];
            return new Complex[] { new Complex(root, 0) };
        }
    }
}
