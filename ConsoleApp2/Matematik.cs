using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Matematik
    {
        public int FirstNumber { get; set; }

        public int LastNumber { get; set; }

        public string MathOperator { get; set; }

        public Matematik(int firstNumber, string mathOperator, int lastNumber)
        {
            FirstNumber = firstNumber;
            LastNumber = lastNumber;
            MathOperator = mathOperator;
        }

    }
}
