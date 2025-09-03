using System;
using System.Text.RegularExpressions;

namespace Calculator;

public class Addition : IOperation
{
    public double perform(double a, params double[] operands)
    {
        return a + operands[0];
    }
}
public class Subtraction : IOperation
{
    public double perform(double a, params double[] operands)
    {
        return a - operands[0];
    }
}
public class Multiplication : IOperation
{
    public double perform(double a, params double[] operands)
    {
        return a * operands[0];
    }
}
public class Division : IOperation
{
    public double perform(double a, params double[] operands)
    {

        try
        {
            return a / operands[0];
        }
        catch (Exception e)
        {
            System.Console.WriteLine(e);
            return 0;
        }
    }
}
public class SquareRoot : IOperation
{
    public double perform(double a, params double[] operands)
    {
        return Math.Sqrt(a);
    }
}
public class Power : IOperation
{
    public double perform(double a, params double[] operands)
    {
        return Math.Pow(a, operands[0]);
    }
}
public class Modulo : IOperation
{
    public double perform(double a, params double[] operands)
    {
        return a % operands[0];
    }
}
