using System;

namespace AdapteApp
{
    class Program
    {
        static void Main(string[] args)
        {
             //este es el cliente
            int resultado = 0;
            //usamos la interface que el cliente conoce como una clase que conoce
            ITarget calcu = new CCalcu();

            resultado = calcu.Sumar(4, 3);
            Console.WriteLine("El resultado es {0}", resultado);

            Console.WriteLine(".......");


            //hacemos uso del adaptador 
            calcu = new CAdaptador();

            //usamos el adaptador para hacer la operacion
            resultado = calcu.Sumar(5, 6);
            Console.WriteLine("El resultado es {0}", resultado);
            Console.ReadKey();
        }
    }
}
