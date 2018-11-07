using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomListClass
{
    public class BriansList<T>
    {
        int capacity;
        T[] arr;
        int count;

        public BriansList()
        {
            count = 0;
            capacity = 10;
            arr = new T[capacity];
        }
        // count?
        public void Add (T item)
        {
            arr = new T[] { item };
            count++;
        }

        public void Capacity()
        {
            if (capacity == 10)
            {
                capacity = capacity * 2;
            }
        }
        
        public int Count
        {
            get { return count; }
        }



        public T this[int i]
        {
            get { return arr[i]; }
            set { arr[i] = value; }
        }

    }
}
