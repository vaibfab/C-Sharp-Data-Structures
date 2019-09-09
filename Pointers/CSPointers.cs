using System;

namespace Pointers
{
    class CSPointers
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\tPointers in C#");
            Console.WriteLine("\t\t**************");
            int dataVariable = 5;
            unsafe
            {
                int* ptr = &dataVariable;
                Console.WriteLine(" dataVariable :\t{0}", dataVariable);
                Console.WriteLine("*ptr:\t{0}", *ptr);
                Console.WriteLine("memory location of dataVariable(ptr):\t{0}", (int)ptr);
                Console.WriteLine("&dataVariable:\t{0}", (int)&dataVariable);
            }
            Console.ReadKey();
        }
    }
}
