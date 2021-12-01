using System;
using System.Collections.Generic;
using System.Text;

namespace InterpreterApp
{
    internal class TenExpression : InterpreterEvaluate
    {
        public void Evaluate(NumberExpression context)
        {
            try
            {
                context.result = context.number * 10;
                Console.WriteLine("La expresión del número diez es {0}", context.result);
            }
            catch (Exception ex)
            {
                Console.WriteLine("El número tiene que ser entero");
            }

        }
    }
}
