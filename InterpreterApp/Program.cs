using System;
using System.Collections.Generic;

namespace InterpreterApp
{
    class Program
    {
        static void Main(string[] args)
        {
            NumberExpression context = new NumberExpression();
            List<InterpreterEvaluate> objectExpressions = new List<InterpreterEvaluate>();

            try{
                Console.WriteLine("Seleccione su expresión numérica (diez o cien)");

                context.expression = Console.ReadLine()?.ToLower();

                if (context.expression == "") throw new ArgumentNullException("La expresión no puede estar vacía");

                if (context.expression == "diez") objectExpressions.Add(new TenExpression());

                if (context.expression == "cien") objectExpressions.Add(new HundredExpression());

                Console.WriteLine("Por favor, inserte un número entero");

                context.number = Convert.ToInt32(Console.ReadLine());

                objectExpressions.ForEach(expression =>
                { expression.Evaluate(context);});

            }
            catch (Exception ex){
                if (ex is ArgumentException){
                    Console.WriteLine(((ArgumentException)ex).ParamName);
                }
                else{
                    Console.WriteLine("El número debe ser un entero");
                }

            }
            Console.ReadKey();
        }
    }
}
