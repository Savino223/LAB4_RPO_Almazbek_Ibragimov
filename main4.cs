using System;
using Inter;
using Equation_Bases;
using Equations;
using solvers;
using Comp;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Введите коэфициенты уравнения, разделенные пробьелами");
        double[] coeffs;
        while (true)
        {
            string input = Console.ReadLine();
            if (TryParser(input, out coeffs))
                break;
            else
                Console.WriteLine("Неправильный ввод. Повтори");
        }

        try
        {
            Equation equation = new Equation(coeffs);
            Complex[] roots = equation.Find_Roots();
            Console.WriteLine("Корни:");
            foreach (Complex root in roots)
            {
                Console.WriteLine(root);
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

    public static bool TryParser(string input, out double[] coefs)
    {
        string[] parts = input.Split(' ');
        coefs = new double[parts.Length];
        for (int i = 0; i < parts.Length; i++)
        {
            if (!double.TryParse(parts[i], out coefs[i]))
                return false;
        }

        if (coefs.All(c => c == 0))
        {
            return false;
        }

        if (coefs[0] == 0)
        {
            return false;
        }

        return true;
    }

}