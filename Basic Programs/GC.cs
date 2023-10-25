using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Programs
{
    internal class GC
    {
        public void ListHandling()
        {
            List<string> numbers = new List<string>();

            numbers.Add("10");
            numbers.Add("200");
            numbers.Add("300");
            /*
             for (int i = 0; i < arrayList.Count; i++)
             {
                 Console.WriteLine(arrayList[i]);
             }*/
            numbers.Add("33");
            numbers.Add("55");


            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }
            numbers.Reverse();
            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }
            numbers.RemoveAt(3);
            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }
            numbers.Clear();
            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(numbers.Contains("10"));
            Console.WriteLine(numbers.IndexOf("20"));
        }
        public void Dicthandling()
        {
            Dictionary<int, string> dict = new Dictionary<int, string>();



            dict.Add(1, "10");
            dict.Add(2, "20");
            dict.Add(3, "30");
            dict.Add(5, "AA");
            dict.Add(4, "aa");


            foreach (var item in dict)
            {
                Console.WriteLine(item);
            }
            dict.Remove(3);
            foreach (var item in dict)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(dict.ContainsKey(3));
            foreach (var item in dict.Keys)
            {
                Console.WriteLine(item);
            }
            foreach (var item in dict.Values)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Count" + dict.Count);


        }
        public void SLHandling()
        {

            SortedDictionary<int, string> st = new SortedDictionary<int, string>();
            st.Add(3, "30");
            st.Add(4, "aaa");
            st.Add(1, "bbb");
            st.Add(2, "20");


            foreach (var item in st)
            {
                Console.WriteLine(item);

            }
        }
    }
}
        



    

