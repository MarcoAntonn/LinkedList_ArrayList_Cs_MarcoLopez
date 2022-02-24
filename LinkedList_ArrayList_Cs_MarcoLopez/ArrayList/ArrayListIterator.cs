using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList_ArrayList_Cs_MarcoLopez.ArrayList
{
    internal class ArrayListIterator
    {
        private ArrayList1 arrayList;
        private int currentItem;

        //Constructor
        public ArrayListIterator(ArrayList1 arrayList)
        {
            this.arrayList = arrayList;
        }

        public bool hasNext()
        {
            return currentItem < arrayList.getSize(); //Regresa verdadero si el currentItem es menor al size del arrayList
        }

        public String next()
        {
            String data = arrayList.getAt(currentItem);

            currentItem++;

            return data;
        }
    }
}

