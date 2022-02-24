﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList_ArrayList_Cs_MarcoLopez.ArrayList
{
    internal class ArrayList1
    {
        private static int DEFAULT_SIZE = 2; //Esto es una declaración de constantes
        private String[] array;
        private int size;

        //Sobrecarga (cuando no le pasan parámetros)
        public ArrayList1()
        {
            array = new String[DEFAULT_SIZE];
        }

        //Constructor
        public ArrayList1(int size)
        {
            array = new String[size];
        }

        //Adds
        public void addAtTail(String data)
        {
            if (size == array.Length)
            { //Si el numero de datos validos y el tamaño del arreglo, entonces ya no cabe y se usa el metodo increaseArraySize
                increaseArraySize();
            }

            array[size] = data;
            size++;
        }

        public void addAtFront(string data)
        {
            if (size == array.Length)
            {
                increaseArraySize();
            }
            if (size >= 0)
            {
                Array.Copy(array, 0, array, 1, size); //Recorrido y sussttitución
            }
            array[0] = data;

            size++;
        }

        //Removes
        public void remove(int index)
        {
            if (index < 0 || index >= size)
            {
                return;
            }

            if (size - 1 - index >= 0)
            {
                Array.Copy(array, index + 1, array, index, size - 1 - index);
            }
            array[size - 1] = null; //Aqui el garbage collector recoge despues la info sobrante
            size--;
        }

        public void removeAll()
        {
            for (int i = 0; i < size; i++)
            {
                array[i] = null;
            }
            size = 0;
        }

        //Setters
        public void setAt(int index, String data)
        {
            if (index >= 0 && index < size)
            {
                array[index] = data;
            }
        }

        //Getters
        public String getAt(int index)
        {
            return index >= 0 && index < size ? array[index] : null; //Si index es mayor o igual a 0 y menor que size, entonces array[inndex] es igual a null
        }

        public int getSize()
        {
            return size;
        }

        public ArrayListIterator getIterator()
        {
            return new ArrayListIterator(this);
        }

        public static String getName()
        {
            return "ArrayList";
        }

        //Otros métodos
        private void increaseArraySize()
        {
            String[] newArray = new String[array.Length * 2];

            for (int i = 0; i < size; i++)
            {
                newArray[i] = array[i];
            }
            array = newArray;
        }
    }
}

