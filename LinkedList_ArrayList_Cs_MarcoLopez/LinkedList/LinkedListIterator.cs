using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList_ArrayList_Cs_MarcoLopez.LinkedList
{
    internal class LinkedListIterator
    {
        private Node currentNode; //Este es como el aux

        //Constructor
        public LinkedListIterator(Node startNode)
        {
            currentNode = startNode;
        }

        //Otros métodos
        public bool hasNext()
        {
            return currentNode != null;
        }

        public string next()
        {
            string data = currentNode.data;
            currentNode = currentNode.next;
            return data;
        }
    }
}
