using System;
using System.Collections.Generic;
using System.Text;

namespace InterpreterApp
{
    internal interface InterpreterEvaluate
    {
        void Evaluate(NumberExpression context);
    }
}
