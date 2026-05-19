using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABB_semana_9
{
    internal class Arbol
    {
        public Nodo Raiz;

        public void Insertar(int v)
        {
            Raiz = InsertarRecursivo(Raiz, v);
        }
        private Nodo InsertarRecursivo(Nodo raiz, int valor)
        {
            if (raiz == null) return new Nodo(valor);

            if (valor < raiz.valor)
                raiz.izq = InsertarRecursivo(raiz.izq, valor);
            else
                raiz.der = InsertarRecursivo(raiz.der, valor);

            return raiz;
        }
        public bool Buscar(Nodo raiz, int objetivo)
        {
            if (raiz == null) return false;
            if (raiz.valor == objetivo) return true;

            if (objetivo < raiz.valor)
            {
                return Buscar(raiz.izq, objetivo);
            }
            else
            {
                return Buscar(raiz.der, objetivo);
            }
        }
        public void RecorrerEnOrden(Nodo raiz)
        {
            if (raiz != null)
            {
                RecorrerEnOrden(raiz.izq);
                Console.Write(raiz.valor + " ");
                RecorrerEnOrden(raiz.der);
            }
        }
        public void RecorrerPreOrden(Nodo raiz)
        {
            if (raiz != null)
            {
                Console.Write(raiz.valor + " ");
                RecorrerPreOrden(raiz.izq);
                RecorrerPreOrden(raiz.der);
            }
        }
        public void RecorrerPosOrden(Nodo raiz)
        {
            if (raiz != null)
            {
                RecorrerPosOrden(raiz.izq);
                RecorrerPosOrden(raiz.der);
                Console.Write(raiz.valor + " ");
            }
        }

    }
}
