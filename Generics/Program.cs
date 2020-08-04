using System;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {

            //LinkedListClass<int> check = new LinkedListClass<int>();

            //check.AddItem(2);
            //check.AddItem(3);
            //Console.WriteLine(check.AddItem(3));

            // check.AddItem(4);
            //check.InsertAt(0, 5);
            // check.InsertAt(2, 100);
            // Console.WriteLine(check.IndexItem(100));
            // Console.WriteLine(check.IndexItem(5));
            // check.Remove(100);
            // Console.WriteLine(check.IndexItem(100));

            StackClass<int> value = new StackClass<int>();
            value.Push(1);
            value.Push(2);
            value.Push(3);

            foreach (var item in value)
            {
                Console.WriteLine(item);
            }
        }
    }
}
