using System;
using System.Collections.Generic;
using System.Text;

namespace CompositeApp
{
    class Componente<T> : IComponente<T>
    {

        //IDENTIFICADOR DEL COMPONENTE
        public T Nombre { get; set; }
        public Componente(T pNombre)
        {
            Nombre = pNombre;

        }


        public void Adicionar(IComponente<T> pElemento)
        {

            Console.WriteLine("Solo se adiciona a los compuestos, no a los componentes");

        }

        public IComponente<T> Borrar(T pElemento)
        {


            Console.WriteLine("no se puede borrar directamente");

            return this;

        }

        public IComponente<T> Buscar(T pElemento)
        {
            if (pElemento.Equals(Nombre))
                return this;
            else
                return null;
        }

        public string Mostrar(int pProfundidad)
        {

            //colocamos la cantidad segun de la profundidad
            return new String('-', pProfundidad) + Nombre + "\n\r";

        }


    }
}
