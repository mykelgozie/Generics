using System;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Linked List implementation ");
            LinkedListClass<int> check = new LinkedListClass<int>();

            check.AddItem(2);
            check.AddItem(3);
            Console.WriteLine(check.AddItem(3));

            check.AddItem(4);
            Console.WriteLine("Insert at a particular position ");
            check.InsertAt(0, 5);
            check.InsertAt(2, 100);
            Console.WriteLine(check.IndexItem(100));
            Console.WriteLine(check.IndexItem(5));
            check.Remove(100);
            Console.WriteLine(check.IndexItem(100));


            LinkedListClass<int> link = new LinkedListClass<int>();
            link.AddItem(1);
            link.AddItem(2);
            link.AddItem(3);

            Console.WriteLine(" check() returns if a value is present or absent true or false");
            Console.WriteLine(link.Check(1));
            Console.WriteLine(" serach() find and return value ");
            Console.WriteLine(link.Search(1));
            Console.WriteLine(" size() return the size of Lnk");
            Console.WriteLine(link.size());

            StackClass<int> value = new StackClass<int>();
            value.Push(1);
            value.Push(2);
            value.Push(3);

            foreach (var item in value)
            {
                Console.WriteLine(item);
            }


            Console.WriteLine(" Queue");

            QueueClass<int> tests = new QueueClass<int>();
            tests.Enqueue(1);
            tests.Enqueue(2);
            tests.Enqueue(3);
            tests.Enqueue(4);
            tests.Dequeue();
            Console.WriteLine(tests.Peek());

            foreach (var test in tests)
            {
                Console.WriteLine(test);
            }

           
            
        }
    }
}
