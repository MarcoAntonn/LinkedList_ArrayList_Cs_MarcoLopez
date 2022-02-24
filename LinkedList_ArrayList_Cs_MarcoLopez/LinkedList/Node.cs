using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList_ArrayList_Cs_MarcoLopez.LinkedList
{
    internal class Node
    {
        public string data; //Los atributos se inicializan en null por defaul
        public Node next;
        public Node previous;

        //Constructor
        public Node(string data)
        {
            this.data = data;
        }

        //Esto no está en el codigo PLANTUML
        public void setData(String data)
        {
            this.data = data;
        }

        public void setNext(Node next)
        {
            this.next = next;
        }

        public void setPrevious(Node previous)
        {
            this.previous = previous;
        }

        public Node getNext()
        {
            return next;
        }

        public Node getPrevious()
        {
            return previous;
        }

        public String getData()
        {
            return data;
        }
    }
}



