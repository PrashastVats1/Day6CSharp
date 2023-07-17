using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppGenericCollectionsEx
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ArrayList arrayList = new ArrayList()
            //{ 1, "Sam", 'A', DateTime.Now};
            //Console.WriteLine("item \t Data Type");
            //foreach(var item in arrayList)
            //{
            //    Console.WriteLine(item + "\t" + item.GetType());
            //}
            //Console.WriteLine("\n");
            //ArrayList nameList = new ArrayList() { "Raj", "Ravi", "Amit"};
            //Console.WriteLine("Name List as follows");
            //foreach(var item in nameList)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine("\n");
            //nameList.Add(12);
            //nameList.Add(DateTime.Now);
            //Console.WriteLine("Name List as follows");
            //foreach (var item in nameList)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine("\n");

            List<string> listNames = new List<string>()
            { "Sam", "Ravi", "Amit"};
            Console.WriteLine("**** Name List ****");
            foreach(var item in listNames)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("\n");
            listNames.Add("Renu");
            Console.WriteLine("**** Name List after adding one more item ****");
            foreach (var item in listNames)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("\n");

            List<int> listNumbers = new List<int>()
            {128, 64, 32, 16};
            Console.WriteLine("**** Number List ****");
            foreach (var item in listNumbers)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("\n");
            listNumbers.Add(256);
            Console.WriteLine("**** NUmber List after adding one more item ****");
            foreach (var item in listNumbers)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();

        }
    }
}
