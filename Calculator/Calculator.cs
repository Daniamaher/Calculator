using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Calculator
    {
        public double X { get; set; }
        public double Y { get; set; }

        public Calculator(double x, double y)
        {
            X = x;
            Y = y;
        }

        public double Add()
        {
            return X + Y;
        }

        public double Subtract()
        {
            return X - Y;
        }

        public double Multiply()
        {
            return X * Y;
        }

        public double Divide()
        {
            if (Y == 0)
            {
                return double.NaN;
            }
            return X / Y;
        }
    }
}
