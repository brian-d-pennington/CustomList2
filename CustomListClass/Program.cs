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
            BriansList<int> listOne = new BriansList<int>();
            BriansList<int> listTwo = new BriansList<int>();
            BriansList<int> listToSubtract = listOne;
            listOne.Add(1);
            listOne.Add(2);
            listOne.Add(3);
            listTwo.Add(4);
            listTwo.Add(5);
            listTwo.Add(6);
            BriansList<int> newList = listOne + listTwo;
            
            //Act
            BriansList<int> reducedList = newList - listOne;
            


        }
    }
}
