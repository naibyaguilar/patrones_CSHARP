using System;
using System.Collections.Generic;
using System.Text;

namespace FacadeApp
{
    class Embrague : IEmbrague
    {

        public void PresionarEmbrague()
        {
            Console.WriteLine("Embrague presionado");
        }

        public void SoltarEmbrague()
        {
            Console.WriteLine("Embrague suelto");
        }


    }
}
