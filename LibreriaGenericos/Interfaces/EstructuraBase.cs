using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lab_04_ED.LibreriaGenericos.Estructuras;

namespace Lab_04_ED.LibreriaGenericos.Interfaces
{
    public abstract class EstructuraBase<T>
    {
        protected abstract void Insertar(T Valor, Delegate Delegado, Nodo<T> NodoRaiz);
        protected abstract void Borrar(Nodo<T> NodoRaiz, int Inicio);
        protected abstract T Obtener();
    }
}