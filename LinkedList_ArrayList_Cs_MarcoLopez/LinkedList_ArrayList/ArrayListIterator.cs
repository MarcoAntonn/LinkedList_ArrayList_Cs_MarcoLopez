using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList_ArrayList_Cs_MarcoLopez.LinkedList_ArrayList
{
    internal class ArrayListIterator<T>:Iterator<T>
    {
        private ArrayList1<T> arrayList;
        private int currentItem;

        //Constructor
        public ArrayListIterator(ArrayList1<T> arrayList)
        {
            this.arrayList = arrayList;
        }

        public bool hasNext()
        {
            return currentItem < arrayList.getSize(); //Regresa verdadero si el currentItem es menor al size del arrayList
        }

        public T next()
        {
            T data = arrayList.getAt(currentItem);

            currentItem++;

            return data;
        }
    }
}

