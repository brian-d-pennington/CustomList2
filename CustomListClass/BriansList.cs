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
            for (int j = 0; j < arr.Length; j++)
            {
                T[] localArr = new T[arr.Length];
                localArr[j] = arr[j];
                if (!item.Equals(arr[j]))
                {
                    // nothing found
                }
                else if (item.Equals(arr[j]))
                {
                    localArr[j] = arr[j + 1]; // skips index, resumes loop
                    for (int k = 0; k < arr.Length; k++)
                    {
                        localArr[k] = arr[k];
                    }
                }
                arr = localArr;
            }
        }

        public T ListConcat operator+ (T item, T item)
        {
            BriansList<int> newList = new BriansList<int>();
            newList = listOne + listTwo;

        }
    public static Box operator+ (Box b, Box c)
        {
            Box box = new Box();
            box.length = b.length + c.length;
            box.breadth = b.breadth + c.breadth;
            box.height = b.height + c.height;
            return box;
        }

    }
}
