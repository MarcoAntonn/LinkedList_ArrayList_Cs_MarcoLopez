using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList_ArrayList_Cs_MarcoLopez.LinkedList_ArrayList
{
    internal class Node<T>
    {
        public T data; //Los atributos se inicializan en null por defaul
        public Node<T> next;
        public Node<T> previous;

        //Constructor
        public Node(T data)
        {
            this.data = data;
        }

        //Esto no está en el codigo PLANTUML
        public void setData(T data)
        {
            this.data = data;
        }

        public void setNext(Node<T> next)
        {
            this.next = next;
        }

        public void setPrevious(Node<T> previous)
        {
            this.previous = previous;
        }

        public Node<T> getNext()
        {
            return next;
        }

        public Node<T> getPrevious()
        {
            return previous;
        }

        public T getData()
        {
            return data;
        }
    }
}



