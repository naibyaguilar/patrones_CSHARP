using System;
using System.Collections.Generic;
using System.Text;

namespace commandApp
{
    public class Calculator
    {
        int vinit, curr = 0;
        public void Operation(char @operator, int operand)
        {
            switch (@operator)
            {
                case '+': curr += operand; break;
                case '-': curr -= operand; break;
                case '*': curr *= operand; break;
                case '/': curr /= operand; break;
            }
            Console.WriteLine(
                "Operacion {0} {2} {3} = {1}",
                vinit, curr, @operator, operand);
            vinit = curr;
            Console.WriteLine("    ");
        }
    }
}
