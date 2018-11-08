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
        public void Add(T item)
        {
            if (count == capacity)
            {
                capacity = capacity * 2;
                T[] tempArr = new T[capacity];
                for (int j = 0; j < count; j++)
                {
                    tempArr[j] = arr[j];
                }
                arr = tempArr;
            }
            arr[count] = item;
            count++;
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

        public void Remove(T item)
        {
            T[] localArr = new T[count];
            bool itemHasBeenFound = false;
            int localCount =0;
            for (int j = 0; j < count; j++)
            {
                if (itemHasBeenFound == false)
                {
                    if (!item.Equals(arr[j]))
                    {
                        localArr[j] = arr[j];
                    }
                    else
                    {
                        localArr[j] = arr[j + 1];
                        itemHasBeenFound = true;
                        count -= 1;
                        localCount = count;
                    }
                }
                
                else
                {
                    localArr[j] = arr[j + 1];
                }
               
            }
            arr = localArr;
        }

    
        //public static BriansList<int> newList operator +(listOne, listTwo)
        //{
            //BriansList<int> newList = new BriansList<int>();
            //newList = listOne + listTwo;
            //return newList;
        //}
    
        public override string ToString()
        {
            StringBuilder newString = new StringBuilder();
            for (int i = 0; i < count; i++)
            {
                newString.Append(arr[i]);
            }
            var stringHolder = newString.ToString();
            return stringHolder;
        }
        

    }
}
