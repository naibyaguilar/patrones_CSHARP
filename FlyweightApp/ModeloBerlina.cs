using System;
using System.Collections.Generic;
using System.Text;

namespace FlyweightApp
{
    class ModeloBerlina : ModeloVehiculo
    {
        internal ModeloBerlina(string marca, string modelo, string color): base(marca, modelo, color){}

        public override void MostrarCaracteristicas(string datosExtra)
        {
            base.MostrarCaracteristicas(datosExtra);
        }
    }
}
