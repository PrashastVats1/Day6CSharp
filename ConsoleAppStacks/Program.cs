using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppStacks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ArrayList list = new ArrayList();
            //Hashtable ht = new Hashtable();
            //SortedList sortedList = new SortedList();
            //Stack stck = new Stack();
            //Queue queue = new QUeue();


            //Stack stack = new Stack();
            //stack.Push("Aman");
            //stack.Push("Vijay");
            //stack.Push("Zoya");
            //stack.Push("Kiran");
            //stack.Push("Raj");
            //Console.WriteLine("Number of items in stack: \t" + stack.Count);
            //foreach (var item in stack)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine("\n"); ;

            //Console.WriteLine("After removing: " + stack.Pop());
            //Console.WriteLine("After removing: " + stack.Pop());
            //Console.WriteLine("Number of items in stack: \t" + stack.Count);
            //foreach (var item in stack)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine("\n"); ;

            //Console.WriteLine("Peek Example: \t" + stack.Peek());
            //Console.WriteLine("After Peek");
            //Console.WriteLine("Number of items in queue are: \t" + stack.Count);
            //foreach (var item in stack)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine("\n"); ;

            //stack.Clear();
            //Console.WriteLine("After clearing, number of items are: \t" + stack.Count);

            Queue queue = new Queue();
            queue.Enqueue("Aman");
            queue.Enqueue("Vijay");
            queue.Enqueue("Zoya");
            queue.Enqueue("Kiran");
            queue.Enqueue("Raj");
            Console.WriteLine("Number of items in stack: \t" + queue.Count);
            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("\n"); ;

            Console.WriteLine("After removing: " + queue.Dequeue());
            Console.WriteLine("After removing: " + queue.Dequeue());
            Console.WriteLine("Number of items in stack: \t" + queue.Count);
            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("\n"); ;

            Console.WriteLine("Peek Example: \t" + queue.Peek());
            Console.WriteLine("After Peek");
            Console.WriteLine("Number of items in queue are: \t" + queue.Count);
            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("\n"); ;

            queue.Clear();
            Console.WriteLine("After clearing, number of items are: \t" + queue.Count);
            Console.ReadKey();
        }
    }
}
