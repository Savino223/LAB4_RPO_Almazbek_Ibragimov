using System;
using Comp;

namespace Inter
{
    public interface IEquation
    {
        int size { get; }
        double[] Coefficients();
        Complex[] Find_Roots();
    }
}