using System;
using System.Collections.Generic;
using System.Text;

namespace FacadeApp
{
    class Acelerador : IAcelerador
    {
        public void PresionarAcelerador()
        {
            Console.WriteLine("Acelerador presionado");
        }

        public void SoltarAcelerador()
        {
            Console.WriteLine("Acelerador levantado");
        }

    }
}
