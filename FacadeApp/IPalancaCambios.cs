using System;
using System.Collections.Generic;
using System.Text;

namespace FacadeApp
{
    interface IPalancaCambios
    {
        void InsertarVelocidad(int velocidad);
        void PuntoMuerto();
        int GetVelocidadActual();
    }
}
