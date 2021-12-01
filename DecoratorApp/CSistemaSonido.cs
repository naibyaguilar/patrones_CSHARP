using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorApp
{
    class CSistemaSonido : IComponente
    {
        //variable de referencia hacia quien decoramos
        private IComponente decoramosA;
        //pasamos al objeto que va a sr decorado
        public CSistemaSonido(IComponente pComponente)
        {
            decoramosA = pComponente;
        }

        public override string ToString()
        {
            return "Radio 350XZ+\r\n" + decoramosA.ToString();
        }

        //METODOS DE LA INTERFAZ
        public double Costo()
        {
            //calculamos el costo
            //el costo de los que decoro mas mi componente
            return decoramosA.Costo() + 3500;
        }
        public string Funciona()
        {
            return decoramosA.Funciona() + ",Enciende el radio";
        }
    }
}
