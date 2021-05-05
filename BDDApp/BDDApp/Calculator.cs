using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDDApp
{
    public class Calculator
    {
        public int Num1 { get; set; }
        public int Num2 { get; set; }

        public int Add()
        {
            return Num1 + Num2;
        }

        public int Subtract()
        {
            return Num1 - Num2;
        }

        public int Multiply()
        {
            return Num1 * Num2;
        }

        public int Divide()
        {
            if (Num2 == 0) throw new Exception("Cannot Divide By Zero");
            return Num1 / Num2;
        }
        public int SumOfEvenNumbersInAList(List<int> myList)
        {
            int sum = 0;
            foreach (var num in myList)
            {
                if (num % 2 == 0)
                    sum += num;
            }
            return sum;
        }
    }
}
