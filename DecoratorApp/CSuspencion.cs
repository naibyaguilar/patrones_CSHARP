using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorApp
{
    class CSuspencion : IComponente
    {
        //variable de rewferencia hacia quien decoramos 
        private IComponente decoramosA;
        //pasamos al objeto que va a ser decorado

        public CSuspencion(IComponente pComponente)
        {
            decoramosA = pComponente;
        }

        public override string ToString()
        {
            return "Suspension de alto desempeño \r\n" + decoramosA.ToString();
        }

        public double Costo()
        {
            //Calculamos el costo
            //el costo de lo que decoro mas mi costo como componente
            return decoramosA.Costo() + 63850;
        }
        public string Funciona()
        {
            return decoramosA.Funciona() + ", Elevando suspencion";
        }
    }
}
