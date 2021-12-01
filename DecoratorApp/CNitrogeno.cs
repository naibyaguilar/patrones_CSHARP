using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorApp
{
    class CNitrogeno : IComponente
    {
        //Variable de referencia hacia quien decoramos
        private IComponente decoramosA;
        //Pasamos al objeto que va a ser decorado 
        public CNitrogeno(IComponente pComponente)
        {
            decoramosA = pComponente;
        }

        public override string ToString()
        {
            return "sistema de nitrogeno \r\n" + decoramosA.ToString();
        }
        //metodo de la interfaz 
        public double Costo()
        {
            //calculamos el costo}
            //el costo de lo que decoro mas mi costo como componente
            return decoramosA.Costo() + 45000;
        }

        public string Funciona()
        {
            return decoramosA.Funciona() + ", Nitrogeno listo";
        }

        public void UsaN()
        {
            Console.WriteLine("Nitrogeno en uso");
        }
    }
}
