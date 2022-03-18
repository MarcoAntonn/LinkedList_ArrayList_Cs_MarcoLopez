using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList_ArrayList_Cs_MarcoLopez.LinkedList_ArrayList
{
    internal class LinkedListIterator<T>:Iterator<T>
    {
        private Node<T> currentNode; //Este es como el aux

        //Constructor
        public LinkedListIterator(Node<T> startNode)
        {
            currentNode = startNode;
        }

        //Otros métodos
        public bool hasNext()
        {
            return currentNode != null;
        }

        public T next()
        {
            T data = currentNode.data;
            currentNode = currentNode.next;
            return data;
        }
    }
}
