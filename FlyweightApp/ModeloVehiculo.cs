using System;
using System.Collections.Generic;
using System.Text;

namespace FlyweightApp
{
    public abstract class ModeloVehiculo
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Color { get; set; }

        public ModeloVehiculo(string marca, string modelo, string color)
        {
            this.Marca = marca;
            this.Modelo = modelo;
            this.Color = color;
        }

        public virtual void MostrarCaracteristicas(String datosExtra)
        {
            Console.WriteLine(Marca + " " + Modelo + " de color " + Color + " " + "\n" + datosExtra + "\n");
        }
    }
}
