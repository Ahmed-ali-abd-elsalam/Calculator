using System;

namespace Calculator;

public class Calculator
{
    Stack<Tuple<IOperation, double[]>> History { get; } = new Stack<Tuple<IOperation, double[]>>();

    public double performOperation(IOperation operation, double a, params double[] operands)
    {
        double res = operation.perform(a, operands);
        History.Push(
           new Tuple<IOperation, double[]>(operation, [a, operands[0]])
        );
        return res;
    }
}
