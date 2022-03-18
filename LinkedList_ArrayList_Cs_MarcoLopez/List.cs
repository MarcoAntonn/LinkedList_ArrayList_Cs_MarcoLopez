using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList_ArrayList_Cs_MarcoLopez
{
    internal interface List<T>
    {
        void addAtTail(T data); //esto ya es public (no es necesario ponerselo otra vez) ya que "quien firma el contrato tiene que hacer sus métodos públicos", o sea que ya es public xd, también es abstract

        void addAtFront(T data);

        void remove(int index);

        void removeAll();

        void setAt(int index, T data);

        T getAt(int index);

        Iterator<T> getIterator();

        int getSize();
    }
}



