using System;
using System.Collections.Generic;
using System.Text;

namespace CompositeApp
{
    class Compuesto<T> : IComponente<T>
    {
        //LISTA DONDE GUARDAMOS ELEMENTOS QUE VA A GUARDAR
        List<IComponente<T>> elementos;

        //identificador
        public T Nombre { get; set; }
        public Compuesto(T pNombre)
        {
            Nombre = pNombre;
            //instanciamos la lista
            elementos = new List<IComponente<T>>();
        }
        public void Adicionar(IComponente<T> pElemento)
        {
            elementos.Add(pElemento);
        }

        public IComponente<T> Borrar(T pElemento)
        {
            //buscamos el elemento a borrar
            IComponente<T> elemento = this.Buscar(pElemento);
            //si la encontramos la eliminamos de la lista
            if (elemento != null)
            {
                (this as Compuesto<T>).elementos.Remove(elemento);
            }
            return this;
        }

        public IComponente<T> Buscar(T pElemento)
        {
            //si smos quien busca nos regresamos
            if (Nombre.Equals(pElemento))
                return this;
            IComponente<T> encontrado = null;

            //recorremos la lista y buscamos en nuestros elemento
            foreach (IComponente<T> elemento in elementos)
            {
                encontrado = elemento.Buscar(pElemento);
                if (encontrado != null)
                    break;
            }
            return encontrado;
        }

        public string Mostrar(int pProfundidad)
        {
            //construimos la cadena con una cantidad de - igual a la profundidad
            StringBuilder infoElemento = new StringBuilder(new String('-', pProfundidad));

            //adicionamos la informacion del compuesto
            infoElemento.Append("Compuesto :" + Nombre + "elementos :" + elementos.Count + "\r\n");

            //adicionamos los elementos
            foreach (IComponente<T> elemento in elementos)
                infoElemento.Append(elemento.Mostrar(pProfundidad + 1));
            return infoElemento.ToString();
        }
    }
}
