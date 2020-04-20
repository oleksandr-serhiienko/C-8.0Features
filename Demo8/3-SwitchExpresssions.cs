using System;
using System.Collections.Generic;
using System.Text;

namespace Demo8
{
    public static class SwitchExpresssions
    {
        public static double DoMath(double x, double y, MathType mathType)
        {
            double output = 0;

            output = mathType switch
            {
               MathType.Add => x + y,
               MathType.Substract => x - y,
               MathType.Multiply => x * y,
               MathType.Divide => x / y,
               _=> throw new Exception ("Bad info passed in")
            };

            //switch (mathType)
            //{
            //    case MathType.Add:
            //        output = x + y;
            //        break;
            //    case MathType.Substract:
            //        output = x - y;
            //        break;
            //    case MathType.Multiply:
            //        output = x * y;
            //        break;
            //    case MathType.Divide:
            //        output = x / y;
            //        break;
            //    default:
            //        throw new Exception("Bad info passed in");
            //}

            return output;
        }

        public enum MathType
    {
        Add,
        Substract,
        Multiply,
        Divide
    }
    }
}