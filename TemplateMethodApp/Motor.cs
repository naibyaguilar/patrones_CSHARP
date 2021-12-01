using System;
using System.Collections.Generic;
using System.Text;

namespace TemplateMethodApp
{
    public abstract class Motor
    {
        // Estado de las válvulas
        private bool valvulaAdmisionAbierta = false;
        private bool valvulaEscapeAbierta = false;

        // Ángulos del cigueñal y del árbol de levas
        protected int anguloCiguenal = 0;
        protected int anguloArbolLevas = 0;

        // Método público que ejecutará el algoritmo completo
        /* public void RealizarFaseMotor()
         {
             Admision();             // Parcialmente implementado en la clase base
             Compresion();           // Implementado en la clase base
             ConsumirCombustible();  // Delegado en las clases hijas
             Escape();               // Implementado en la clase base
         }*/

        // Primera Fase: Admisión
        protected void Admision()
        {
            Console.WriteLine("COMENZANDO FASE DE ADMISION");

            // Se abre la válvula de admisión y se cierra la válvula de escape
            valvulaAdmisionAbierta = true;
            valvulaEscapeAbierta = false;

            // Se baja el pistón. Esta operación será distinta en el motor diesel (que
            // inyectará aire) o gasolina (que inyectará una mezcla de aire y combustible)
            BajarPiston();

            anguloCiguenal = SumarAngulo(anguloCiguenal, 180);
            anguloArbolLevas = SumarAngulo(anguloArbolLevas, 90);

            Console.WriteLine("Angulo del ciguenal: " + anguloCiguenal);
            Console.WriteLine("Angulo del arbol de levas: " + anguloArbolLevas);

            Console.WriteLine("Valvula de admision abierta: " + valvulaAdmisionAbierta);
            Console.WriteLine("Valvula de escape abierta: " + valvulaEscapeAbierta + "\n");
        }

        // La bajada del pistón depende del motor concreto, por lo que deberá ser implementada
        // por la clase hija.
        protected abstract void BajarPiston();

        // Segunda Fase: Compresión
        protected void Compresion()
        {
            Console.WriteLine("COMENZANDO FASE DE COMPRESION");

            // Se cierra la válvula de admisión
            valvulaAdmisionAbierta = false;

            // Giros del cigueñal y del árbol de levas
            anguloCiguenal = SumarAngulo(anguloCiguenal, 360);
            anguloArbolLevas = SumarAngulo(anguloArbolLevas, 180);

            Console.WriteLine("Angulo del ciguenal: " + anguloCiguenal);
            Console.WriteLine("Angulo del arbol de levas: " + anguloArbolLevas);

            Console.WriteLine("Valvula de admision abierta: " + valvulaAdmisionAbierta);
            Console.WriteLine("Valvula de escape abierta: " + valvulaEscapeAbierta + "\n");
        }

        // Tercera Fase: Consumo del combustible. Dado que depende del motor concreto,
        // este método será abstracto y deberá ser implementado por la clase derivada.
        protected abstract void ConsumirCombustible();

        // Cuarta Fase: Escape
        protected void Escape()
        {
            Console.WriteLine("COMENZANDO FASE DE ESCAPE");

            // Se abre la válvula de escape
            valvulaEscapeAbierta = true;

            // Giros del cigueñal y del árbol de levas
            anguloCiguenal = SumarAngulo(anguloCiguenal, 180);
            anguloArbolLevas = SumarAngulo(anguloArbolLevas, 90);

            Console.WriteLine("Angulo del ciguenal: " + anguloCiguenal);
            Console.WriteLine("Angulo del arbol de levas: " + anguloArbolLevas);

            Console.WriteLine("Gases expulsados. Fin de ciclo");
        }

        // Método que mantendrá el ángulo entre 0 y 359 grados
        protected int SumarAngulo(int anguloActual, int cantidad)
        {
            if (anguloActual + cantidad >= 360)
                return anguloActual + cantidad - 360;
            else
                return anguloActual + cantidad;
        }

        protected virtual void ComprimirTurbo()
        {
            Console.WriteLine("Turbo no presente");
        }
        // Método público que ejecutará el algoritmo completo
        public void RealizarFaseMotor()
        {
            ComprimirTurbo();       // Hook (método opcional)
            Admision();             // Parcialmente implementado en la clase base
            Compresion();           // Implementado en la clase base
            ConsumirCombustible();  // Delegado en las clases hijas
            Escape();               // Implementado en la clase base
        }
    }
}
