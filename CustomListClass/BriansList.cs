using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomListClass
{
    public class BriansList<T>
    {
       public void Add (T item)
        {
            T[] arr = new T[] { item };
        }

        public T this[int i]
        {
            get { return arr[i]; }
            set { arr[i] = value; }
        }
        public int Concat()
        {
            return 0;
        }

        public int Count()
        {
            return 0;
        }
 
    }
}
