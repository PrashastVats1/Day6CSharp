using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppDictEx
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Dictionary<int, string> students = new Dictionary<int, string>()
            //{
            //    { 15, "Sam"},
            //    { 12, "Raj"},
            //    { 53, "Raju"}
            // };
            //Console.WriteLine("Number of students are: "+ students.Count);
            //Console.WriteLine("Roll \t Name");
            //foreach (var k in students.Keys)
            //{
            //    Console.WriteLine(k + "\t" + students[k]);
            //}
            //Console.WriteLine("\n");
            //students.Add(69, "Shyam");
            //Console.WriteLine("Updated students list");
            //Console.WriteLine("Roll \t Name");
            //foreach (var k in students.Keys)
            //{
            //    Console.WriteLine(k + "\t" + students[k]);
            //}
            //Console.WriteLine("\n");

            //Find and replace-> ctrl+h, comment-> ctrl+k+c, uncomment-> ctrl+k+u

            SortedList<int, string> students = new SortedList<int, string>()
            {
                { 15, "Sam"},
                { 12, "Raj"},
                { 53, "Raju"}
             };
            Console.WriteLine("Number of students are: " + students.Count);
            Console.WriteLine("Roll \t Name");
            foreach (var k in students.Keys)
            {
                Console.WriteLine(k + "\t" + students[k]);
            }
            Console.WriteLine("\n");
            students.Add(69, "Shyam");
            Console.WriteLine("Updated students list");
            Console.WriteLine("Roll \t Name");
            foreach (var k in students.Keys)
            {
                Console.WriteLine(k + "\t" + students[k]);
            }
            Console.WriteLine("\n");

            SortedList<string, string> hardwareList = new SortedList<string, string>()
            {
                { "CD", "Compact Disk"},
                {"HDD", "Hard Disk" },
                {"RAM", "Random Access Memory" },
                {"FDD", "Floppy Disk Drive" }
             };
            Console.WriteLine("Short Form \t Long Form");
            foreach (var k in hardwareList.Keys)
            {
                Console.WriteLine(k + "\t \t" + hardwareList[k]);
            }
            Console.ReadKey();
        }
    }
}
