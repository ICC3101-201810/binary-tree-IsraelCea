using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class ListaNodos<T>: List<Nodo<T>>
    {
        public ListaNodos(): base() { }

        List<Nodo<T>> nodos;
        public ListaNodos(int tamaño)
        {
            for (int i = 0; i < tamaño; i++)
                nodos.Add(default(Nodo<T>));

        }

    }
}
