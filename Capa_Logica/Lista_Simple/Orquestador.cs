using Capa_Modelo.Nodo;

namespace Capa_Logica.Lista_Simple
{
    public class Orquestador
    {
        private NodoInt cabeza;

        public void Agregar_NodoInt(int valor)
        {

            NodoInt nodoNuevo = new NodoInt(valor);

            if (cabeza == null)
            {
                cabeza = nodoNuevo;
            }
            else
            {

                NodoInt nodoActual = cabeza;

                while (nodoActual.Siguiente != null)
                {
                    nodoActual = nodoActual.Siguiente;
                }

                nodoActual.Siguiente = nodoNuevo;
            }

        }
        public void Mostrar_Lista_Simple()
        {

            NodoInt nodoActual = cabeza;

            if (nodoActual != null)
            {
                while (nodoActual != null)
                {
                    int valorActual = nodoActual.Valor;
                    Console.WriteLine(valorActual.ToString());
                    nodoActual = nodoActual.Siguiente;
                }
            }

        }
        public void Busque_Nodo(int _valor_A_Buscar)
        {

            int nodo_lista = 2;
            int nodos_eliminar = 3;

            NodoInt nodoActual = cabeza;

            if (nodoActual.Valor != nodo_lista)
            {
                while (nodoActual.Valor != nodo_lista)
                {
                    int valorActual = nodoActual.Valor;
                    Console.WriteLine(valorActual.ToString());
                    nodoActual = nodoActual.Siguiente;
                }

            }
            else if (nodoActual.Valor == nodo_lista)
            {
                while (nodoActual.Valor == nodo_lista)
                {
                   
                }
            }
        }

    }
}