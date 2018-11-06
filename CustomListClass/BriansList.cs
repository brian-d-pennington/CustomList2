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
            T[] array = new T[] { item };
        }
    }
}
