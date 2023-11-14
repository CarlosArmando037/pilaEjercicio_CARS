using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PilaEjercicio.clases
{
    public class Pila
    {

        private int _cima;
        private int[] listapila;

        private int longitudPila = 5;

        public Pila()
        {
            _cima= -1;
            listapila = new int[longitudPila];
        }
        public bool PilaVacia()
        {
            /*
             if(_cima ==-1){
            return true;
            }
            else{
            return false;
            }
             */
            
            return _cima==-1?true:false;
        }
        public bool PilaLlena()
        {
            if(_cima==longitudPila-1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public int LongitudPila()
        {
            return longitudPila;
        }
        public int CantidadElementos()
        {
            return _cima + 1;
        }
        public int ValorCima()
        {
            return listapila[_cima];
        }
        public bool InsertarValor(int valor)
        {
            if (PilaLlena())
            {
                return false;
            }
            else
            {
                _cima++;
                listapila[_cima] = valor;
                return true;
            }
        }
        public int ExtraerElemento()
        {
            if (PilaVacia())
            {
                Console.WriteLine("pila esta vacia");
                return -1;
            }
            else
            {
                int aux = listapila[_cima];
                _cima--;
                return aux;
            }
        }
        public bool LimpiarPila()
        {
            if (PilaVacia())
            {
                return false;
            }
            else
            {
                while (!PilaVacia())
                {
                    ExtraerElemento();
                }
                return true;
            }
        }
        //tarea imprimir todos los elementos de la pila

    }
}
