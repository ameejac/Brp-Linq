using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Collections;

namespace LinqDemo
{
    class LinqCode
    {
        public void Inumerablemethod()
        {
            int[] data = { 1, 2, 3, 4, 5, 6 };
            IEnumerable<int> dataquery = from datas in data where datas > 2 select datas;
            foreach(var items in dataquery)
            {
                Console.WriteLine(items);
            }
        }
        public void NamesUsingLinQ()
        {
            string[] names = { "red", "orange", "blue", "black", "brinjal" };
            IEnumerable<string> namequery = names.Where(A =>A.Contains ("i"));
            foreach(var elements in namequery)
            {
                Console.WriteLine(elements);
            }
         }
    }
}
