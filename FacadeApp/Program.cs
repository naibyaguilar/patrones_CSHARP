using System;

namespace FacadeApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //MANUAL
            //IAcelerador acelerador = new Acelerador();
            //IEmbrague embrague = new Embrague();
            //IPalancaCambios palancaCambios = new PalancaCambios();

            // acelerador.SoltarAcelerador();
            // embrague.PresionarEmbrague();
            //palancaCambios.PuntoMuerto();
            // palancaCambios.InsertarVelocidad(3);
            // embrague.SoltarEmbrague();
            // acelerador.PresionarAcelerador();


            //AUTIMATICO
            IAcelerador acelerador = new Acelerador();
            IEmbrague embrague = new Embrague();
            IPalancaCambios palancaCambios = new PalancaCambios();

            Centralita centralita = new Centralita(embrague, acelerador, palancaCambios);
            centralita.AumentarMarcha();
            Console.ReadKey();
        }
    }
}
