using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class NodoDoble
    {
        public int valor;
        public NodoDoble siguiente;
        public NodoDoble anterior;

        public NodoDoble(int valor)
        {
            this.valor = valor;
            siguiente = null;
            anterior = null;
        }
    }

    class ListaDoble
    {
        private NodoDoble cabeza;

        public ListaDoble()
        {
            cabeza = null;
        }

        public void Agregar(int valor)
        {
            NodoDoble nuevoNodo = new NodoDoble(valor);
            if (cabeza == null)
            {
                cabeza = nuevoNodo;
            }
            else
            {
                NodoDoble temp = cabeza;
                while (temp.siguiente != null)
                {
                    temp = temp.siguiente;
                }
                temp.siguiente = nuevoNodo;
                nuevoNodo.anterior = temp;
            }
        }

        public void Eliminar(int valor)
        {
            NodoDoble temp = cabeza;
            while (temp != null && temp.valor != valor)
            {
                temp = temp.siguiente;
            }

            if (temp != null)
            {
                if (temp.anterior != null)
                {
                    temp.anterior.siguiente = temp.siguiente;
                }
                else
                {
                    cabeza = temp.siguiente;
                }

                if (temp.siguiente != null)
                {
                    temp.siguiente.anterior = temp.anterior;
                }
            }
        }

        public NodoDoble Buscar(int valor)
        {
            NodoDoble temp = cabeza;
            while (temp != null)
            {
                if (temp.valor == valor)
                    return temp;
                temp = temp.siguiente;
            }
            return null;
        }

        public void Modificar(int valorActual, int nuevoValor)
        {
            NodoDoble nodo = Buscar(valorActual);
            if (nodo != null)
            {
                nodo.valor = nuevoValor;
            }
        }

        public void ImprimirHaciaAdelante()
        {
            NodoDoble temp = cabeza;
            while (temp != null)
            {
                Console.Write(temp.valor + " ");
                temp = temp.siguiente;
            }
            Console.WriteLine();
        }

        public void ImprimirHaciaAtras()
        {
            NodoDoble temp = cabeza;
            if (temp == null) return;

            while (temp.siguiente != null)
            {
                temp = temp.siguiente;
            }

            while (temp != null)
            {
                Console.Write(temp.valor + " ");
                temp = temp.anterior;
            }
            Console.WriteLine();
        }
    }
    class NodoCircular
    {
        public int valor;
        public NodoCircular siguiente;

        public NodoCircular(int valor)
        {
            this.valor = valor;
            siguiente = null;
        }
    }

    class ListaCircular
    {
        private NodoCircular cabeza;

        public ListaCircular()
        {
            cabeza = null;
        }

        public void Agregar(int valor)
        {
            NodoCircular nuevoNodo = new NodoCircular(valor);
            if (cabeza == null)
            {
                cabeza = nuevoNodo;
                cabeza.siguiente = cabeza;
            }
            else
            {
                NodoCircular temp = cabeza;
                while (temp.siguiente != cabeza)
                {
                    temp = temp.siguiente;
                }
                temp.siguiente = nuevoNodo;
                nuevoNodo.siguiente = cabeza;
            }
        }

        public void Eliminar(int valor)
        {
            if (cabeza == null) return;

            NodoCircular actual = cabeza;
            NodoCircular anterior = null;

            do
            {
                if (actual.valor == valor)
                {
                    if (anterior != null)
                    {
                        anterior.siguiente = actual.siguiente;
                        if (actual == cabeza) cabeza = actual.siguiente;
                    }
                    else
                    {
                        NodoCircular temp = cabeza;
                        while (temp.siguiente != cabeza)
                        {
                            temp = temp.siguiente;
                        }
                        temp.siguiente = cabeza.siguiente;
                        cabeza = cabeza.siguiente;
                    }
                    return;
                }
                anterior = actual;
                actual = actual.siguiente;
            } while (actual != cabeza);
        }

        public NodoCircular Buscar(int valor)
        {
            NodoCircular temp = cabeza;
            if (temp == null) return null;

            do
            {
                if (temp.valor == valor)
                    return temp;
                temp = temp.siguiente;
            } while (temp != cabeza);

            return null;
        }

        public void Modificar(int valorActual, int nuevoValor)
        {
            NodoCircular nodo = Buscar(valorActual);
            if (nodo != null)
            {
                nodo.valor = nuevoValor;
            }
        }

        public void Imprimir()
        {
            if (cabeza == null) return;

            NodoCircular temp = cabeza;
            do
            {
                Console.Write(temp.valor + " ");
                temp = temp.siguiente;
            } while (temp != cabeza);
            Console.WriteLine();
        }
    }
}   
