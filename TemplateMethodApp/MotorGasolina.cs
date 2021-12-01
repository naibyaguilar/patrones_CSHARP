using System;
using System.Collections.Generic;
using System.Text;

namespace TemplateMethodApp
{
    public class MotorGasolina : Motor
    {
        protected override void BajarPiston()
        {
            Console.WriteLine("Inyectando aire y combustible en el motor");
        }

        protected override void ConsumirCombustible()
        {
            Console.WriteLine("COMENZANDO FASE DE EXPLOSIÓN");

            Console.WriteLine("Iniciando chispa en la bujía");
            Console.WriteLine("La explosión provoca el movimiento del pistón");

            anguloCiguenal = SumarAngulo(anguloCiguenal, 180);
            anguloArbolLevas = SumarAngulo(anguloArbolLevas, 90);

            Console.WriteLine("Angulo del ciguenal: " + anguloCiguenal);
            Console.WriteLine("Angulo del arbol de levas: " + anguloArbolLevas + "\n");
        }
    }
}
