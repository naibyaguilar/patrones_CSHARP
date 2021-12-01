using System;

namespace TemplateMethodApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Motor mGasolina = new MotorGasolina();
            Motor mDiesel = new MotorDiesel(true);

            mGasolina.RealizarFaseMotor();
            Console.WriteLine("----------------------------------------------------");
            mDiesel.RealizarFaseMotor();
            Console.ReadKey();
        }
    }
}
