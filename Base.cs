using System;
using System.Reflection.Metadata.Ecma335;
using Inter;
using Equations;
using solvers;
using Comp;

namespace Equation_Bases
{
    public class Equation : IEquation
    {
        private readonly double[] coefs;
        private readonly IStrat strat;

        public int size
        {
            get
            {
                return coefs.Length;
            }
        }

        public Equation(double[] coeffs)
        {
            this.coefs = coeffs;
            this.strat = Equationss.SelectStrat(coeffs);
        }

        public double[] Coefficients()
        {
            return coefs;
        }

        public Complex[] Find_Roots()
        {
            return strat.FindRoots(coefs);
        }
    }
}