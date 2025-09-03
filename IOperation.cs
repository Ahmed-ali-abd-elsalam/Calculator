using System;

namespace Calculator;

public interface IOperation
{

    double perform(double a, params double[] operands);
}
