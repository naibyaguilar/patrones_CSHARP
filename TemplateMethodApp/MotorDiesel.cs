using System;
using System.Collections.Generic;
using System.Text;

namespace TemplateMethodApp
{
    class MotorDiesel : Motor
    {
        private bool turbo = false;

        public MotorDiesel(bool turbo)
        {
            this.turbo = turbo;
        }

        protected override void ComprimirTurbo()
        {
            // Si el coche es turbo, ejecutará su propio código. En caso contrario, efectuará
            // la operación por defecto
            if (turbo)
                Console.WriteLine("Comprimiendo aire en el turbo antes de la admisión");
            else
                base.ComprimirTurbo();
        }

        protected override void BajarPiston()
        {
            Console.WriteLine("Inyectando aire en el motor");
        }

        protected override void ConsumirCombustible()
        {
            Console.WriteLine("COMENZANDO FASE DE COMBUSTIÓN");

            Console.WriteLine("Inyectando combustible pulverizado en el motor");
            Console.WriteLine("La presión provoca el movimiento del pistón");

            anguloCiguenal = SumarAngulo(anguloCiguenal, 180);
            anguloArbolLevas = SumarAngulo(anguloArbolLevas, 90);

            Console.WriteLine("Angulo del ciguenal: " + anguloCiguenal);
            Console.WriteLine("Angulo del arbol de levas: " + anguloArbolLevas + "\n");
        }
    }
}
