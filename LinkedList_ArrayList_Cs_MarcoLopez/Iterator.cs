using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList_ArrayList_Cs_MarcoLopez
{
    internal interface Iterator<T>
    {
        bool hasNext();
        T next();
    }
}




