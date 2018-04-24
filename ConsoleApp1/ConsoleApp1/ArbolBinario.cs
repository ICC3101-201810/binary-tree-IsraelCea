using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class ArbolBinario<T>: Nodo<T>
    {
        public ArbolBinario() : base(){ }
        public ArbolBinario(T datos) : base(datos, null) { }
        public ArbolBinario(T datos, ArbolBinario<T> izquierdo, ArbolBinario<T> derecho)
        {
            base.Value = datos;
            ListaNodos<T> hijos = new ListaNodos<T>(2);
            hijos[0] = izquierdo;
            hijos[1] = derecho;
            base.Hijos = hijos;

        }
        public ArbolBinario<T> derecho
        {
            get
            {
                if (base.hijos == null)
                {
                    return null;
                }
                else
                    return (ArbolBinario<T>)base.hijos[0];
            }
            set
            {
                if (base.Hijos == null)
                  

            }
        }



    }
}
