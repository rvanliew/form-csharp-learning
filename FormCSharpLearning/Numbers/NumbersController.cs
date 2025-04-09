using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class NumbersController
{
    public NumbersController()
    {
        //
    }

    public double Add(double valueOne, double valueTwo)
    {
        double total = valueOne + valueTwo;
        // +=
        //return valueOne += valueTwo;
        return total;
    }

    public double Subtract(double valueOne, double valueTwo)
    {
        double total = valueOne - valueTwo;
        return total;
    }

    public double Multiply(double valueOne, double valueTwo)
    {
        double total = valueOne * valueTwo;
        return total;
    }

    public double Divide(double valueOne, double valueTwo)
    {
        double total = valueOne / valueTwo;
        return total;
    }
}
