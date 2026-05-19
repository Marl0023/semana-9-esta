using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABB_semana_9
{
    internal class Nodo
    {
        public int valor { get; set; }
        public Nodo izq { get; set; }
        public Nodo der { get; set; }

        public Nodo(int valor)
        {
            this.valor = valor;
            this.izq = null;
            this.der = null;
        }

    }
}
