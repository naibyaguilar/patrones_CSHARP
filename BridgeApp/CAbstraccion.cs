using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeApp
{
    //esta clase se conecta al cliente con la abstraccion a utilizar
    class CAbstraccion
    {
        //referencia a la implementacion
        IBridge implementacion;
        Dictionary<string, double> productos;
        //metodo 1 es el mas usual
        //constructor, recibimos la implementacion concreta
        public CAbstraccion(IBridge pImp, Dictionary<string, double> pProd)
        {
            implementacion = pImp;
            productos = pProd;
        }
        //metodo 2 cuidado no queermeos hacer una fabrica
        public CAbstraccion(int pTipo, Dictionary<string, double> pProd)
        {

            if (pTipo == 1)
                implementacion = new CImplementacion1();
            if (pTipo == 2)
                implementacion = new CImplementacion2();
            if (pTipo == 3)
                implementacion = new CImplementacion3();

            productos = pProd;
        }
        //estos metodos representan la interfaz que conoce el cliente
        public void MostrarTotales()
        {
            implementacion.MostrarTotales(productos);
        }
        public void Listar()
        {
            implementacion.ListarProductos(productos);
        }
    }
}
