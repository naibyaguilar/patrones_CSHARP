using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorApp
{
    //esta clase representa al componente y debe de implementar
    //a IComponente para poder llevar a cabo la decoracion 
    class CAuto : IComponente
    {
        private string modelo;
        private string caracteristicas;
        public double costo;


        public CAuto(string pModelo, string pCaract, double pCosto)
        {
            modelo = pModelo;
            caracteristicas = pCaract;
            costo = pCosto;
        }

        public void Puertas(bool pEstado)
        {
            if (pEstado)
                Console.WriteLine("Puertas cerradas");
            else
                Console.WriteLine("Puertas abiertas");
        }

        public override string ToString()
        {
            return string.Format("Modelo {0}, {1} \r\n", modelo, caracteristicas);
        }

        //estos son los metodos implementados de IComponente
        public double Costo()
        {
            return costo;
        }

        public string Funciona()
        {
            return "Encendi el motor";
        }
    }
}
