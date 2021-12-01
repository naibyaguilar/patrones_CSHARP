using System;
using System.Collections.Generic;
using System.Text;

namespace AdapteApp
{
    class CAdaptador : ITarget
    {
        //esta clase es el adaptador , usa la interfaz Itarget la cual es conocida por el cliente

        //el adaptador comunica al cliente con la clase adaptada 
        CCalculadoraArray adaptado = new CCalculadoraArray();



        //aqui hacemos la adaptacion de una operacion

        public int Sumar(int pA, int pB)
        {
            double r = 0;
            //creamos el array que necesita el adaptado
            //adaptamos los datos que se envian
            int[] operadores = { pA, pB };
            //realizamos la operacion en el adaptado
            r = adaptado.suma(operadores);
            return (int)r;

        }



    }
}
