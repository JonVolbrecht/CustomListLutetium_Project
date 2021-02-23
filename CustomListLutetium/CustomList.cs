﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomListLutetium
{
    public class CustomList<T>
    {
        //member variable
        private T[] _items;

        private int count;
        private int capacity;

        public CustomList()
        {
            count = 0;
            capacity = 4;
            _items = new T[capacity];
        }

        public void Add(T itemToAdd)
        {
            
            

            if (count == capacity)
            {
                //create new  array
                //move items over
                //new array is now _items array.
                capacity *= 2;
                T[] _items2 = new T[capacity];

                for (int i = 0; i < _items.Length; i++)
                {
                    _items2[i] = _items[i];
                }

                _items = _items2;


            }
            _items[count] = itemToAdd;
            count++;
        }

    }
}
