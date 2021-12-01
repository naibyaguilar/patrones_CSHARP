using System;
using System.Collections.Generic;
using System.Text;

namespace AdapteApp
{
    class CCalculadoraArray
    {

        //esta es la clase que deseamos adaptar, el cliente no la puede usar directamente
        //pues su interfaz es diferente
        public double suma(int[] pOperandos)
        {
            int n = 0;
            int r = 0;
            for (n = 0; n < pOperandos.Length; n++)
                r += pOperandos[n];


            return r;
        }




    }
}
