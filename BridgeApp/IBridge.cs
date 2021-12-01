using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeApp
{
    interface IBridge
    {
        //esta es la interfaz que las implementaciones deben mostrar
        void MostrarTotales(Dictionary<string, double> pProductos);
        void ListarProductos(Dictionary<string, double> pProductos);

    }
}
