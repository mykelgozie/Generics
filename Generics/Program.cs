using System;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            StackClass<int> check = new StackClass<int>();
            check.Push(3);

            check.Print();
        }
    }
}
