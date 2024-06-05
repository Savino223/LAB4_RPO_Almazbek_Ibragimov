using System;
using Inter;
using Comp;

namespace solvers
{
    public interface IStrat
    {
        Complex[] FindRoots(double[] coefficients);
    }
}