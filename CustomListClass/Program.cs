using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomListClass
{
    class Program
    {
        static void Main(string[] args)
        {
            BriansList<int> list = new BriansList<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            
            //Act
            list.Stringifier();
        }
    }
}
