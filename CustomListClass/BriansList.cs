using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomListClass
{
    public class BriansList<T> : IEnumerable
    {
        int capacity;
        public T[] arr; //public for testing
        int count;
        string stringHolder;
     

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

    
        public static BriansList<T> operator+(BriansList<T> listOne, BriansList<T> listTwo)
        {
            BriansList<T> newList = new BriansList<T>();
            for (int i = 0; i < listOne.count; i++)
            {
                newList.Add(listOne[i]);
            }
            for (int i = 0; i < listTwo.count; i++)
            {
                newList.Add(listTwo[i]);
            }
            return newList;
        }

        public static BriansList<T> operator-(BriansList<T> newList, BriansList<T> listToSubtract)
        {
            BriansList<T> reducedList = new BriansList<T>();
            for (int i = 0; i < newList.count; i++)
            {
                if (!listToSubtract[i].Equals(newList[i]))
                {
                    reducedList.Add(newList[i]);
                }
            }
            return reducedList;
        }
        public override string ToString()
        {
            StringBuilder newString = new StringBuilder();
            for (int i = 0; i < count; i++)
            {
                newString.Append(arr[i]);
            }
            string stringHolder = newString.ToString();
            return stringHolder;
        }

        public IEnumerator GetEnumerator()
        {
            foreach (T index in arr)
            {
                yield return index;
            }
        }

        public void ListZipper(BriansList<T> listOne, BriansList<T> listTwo)
        {
            BriansList<T> zippedList = new BriansList<T>();
            for (int i = 0; i < listOne.count + listTwo.count; i++)
            {
                zippedList.Add(listOne[i]);
                zippedList.Add(listTwo[i]);
            }
            arr = zippedList.arr;
            //
        }






    }
}
