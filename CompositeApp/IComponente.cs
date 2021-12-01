using System;
using System.Collections.Generic;
using System.Text;

namespace CompositeApp
{
    interface IComponente<T>
    {
        T Nombre { get; set; }
        void Adicionar(IComponente<T> pElemento);
        IComponente<T> Borrar(T pElemento);
        IComponente<T> Buscar(T pElemento);
        string Mostrar(int pProfundidad);
    }
}
