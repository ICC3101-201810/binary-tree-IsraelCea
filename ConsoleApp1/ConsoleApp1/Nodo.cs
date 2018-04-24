using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Nodo<T>
    {
        public T datos;
        public ListaNodos<T> hijos = null;
        public Nodo() { }
        public Nodo(T datos) : this(datos, null) { }
        public Nodo(T datos, ListaNodos<T> hijos)
        {
            this.datos = datos;
            this.hijos = hijos;
        }

        public T Value
        {
            get
            { return datos; }
            set
            { datos = value; }
        }

        public List<Nodo<T>> Hijos
        {
            get
            { return hijos; }
            set
            { hijos = value; }
        }




    }
}
