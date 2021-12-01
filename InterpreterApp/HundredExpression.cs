using System;
using System.Collections.Generic;
using System.Text;

namespace InterpreterApp
{
    internal class HundredExpression : InterpreterEvaluate
    {
        public void Evaluate(NumberExpression context)
        {
            try
            {
                context.result = context.number * 100;
                Console.WriteLine("La expresión del número cien es {0}", context.result);
            }
            catch (Exception ex)
            {
                Console.WriteLine("El número tiene que ser entero");
            }

        }
    }
}
