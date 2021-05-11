using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkCalculator
{
    class calculations
    {
        public double Value { get; set; }
        public double Number { get; set; }
        public string Calculation { get; set; }
        public bool Operation { get; set; }
        public bool IsDecimalPoint { get; set; }
        public static double Addition(Double Value, Double Num)
        {
            return Value + Num;
        }
        public static double Substraction(Double Value, Double Num)
        {
            return Value - Num;
        }
        public static double Multiplication(Double Value, Double Num)
        {
            return Value * Num;
        }
        public static double Division(Double Value, Double Num)
        {
            return Value / Num;
        }
        public static double SquareRoot(Double Value)
        {
            return Math.Sqrt(Value);
        }
        public static double MathPow(Double Value, double pow)
        {
            return Math.Pow(Value, pow);
        }
        public static double Reciprocal(Double Value, Double Num)
        {
            return 1 / Num;
        }
    }
}
