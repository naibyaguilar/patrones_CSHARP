using System;
using System.Collections.Generic;

namespace BridgeApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //main representa al cliente
            Dictionary<string, double> productos = new Dictionary<string, double>();
            //estos son los productos a usar
            productos.Add("MLOI", 34.67);
            productos.Add("MLO3", 37.67);
            productos.Add("DLO4", 35.97);
            productos.Add("MLO5", 66.67);
            productos.Add("DLO6", 34.47);
            productos.Add("CLO7", 54.57);
            productos.Add("MLO9", 74.47);
            productos.Add("DL10", 55.67);
            productos.Add("CL22", 89.37);
            productos.Add("ML21", 34.67);


            //CREAMOS EL BRIDGE
            // CAbstraccion bridge = new CAbstraccion(new CImplementacion1(), productos);
            CAbstraccion bridge = new CAbstraccion(3, productos);
            bridge.MostrarTotales();
            bridge.Listar();

            Console.ReadKey();
        }
    }
}
