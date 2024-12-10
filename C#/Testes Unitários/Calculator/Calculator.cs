using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Calculator
    {
        public static int Sum(int firstNumber, int secondNumber)
        {
            if (firstNumber < 0 || secondNumber < 0)
            {
                return -1;
            }

            return firstNumber + secondNumber;
        }
    }
}
