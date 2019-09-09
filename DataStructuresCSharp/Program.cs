
using System;

namespace DataStructuresCSharp
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("\tArrays");
            Console.WriteLine("------------------------------");
            CallArray();
            Console.ReadKey();
        }

        public static void CallArray()
        {
            System.Diagnostics.Stopwatch Watch = new System.Diagnostics.Stopwatch();
            int[] arrOne = { 1, 2, 3, 4, 5, 6 };//Decalaring array of integers and initizaling;
            Console.WriteLine("Printing normal array 'arrOne' of type " + arrOne.GetType());
            Print(arrOne);
            int[] arrTwo = arrOne;//Copying arrOne to arrTwo;
            Console.WriteLine();
            Console.WriteLine("Printing copied array 'arrTwo' of type " + arrOne.GetType());
            Print(arrTwo);
            Console.WriteLine("\nAccess in C# Array");
            Console.WriteLine("Direct Access of 4th elem");
            Watch.Start();
            Console.WriteLine("Accessing "+arrOne[3]+" took "+Watch.ElapsedMilliseconds+" ms and "+Watch.ElapsedTicks+" ticks" );
            Watch.Start();
            Console.WriteLine("Accessing las element " + arrOne[arrOne.Length-1] + " took " + Watch.ElapsedMilliseconds + " ms and " + Watch.ElapsedTicks + " ticks");
            try
            {
                Watch.Start();
                Console.WriteLine(arrOne[arrOne.Length]);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Accessing non-existant element took " + Watch.ElapsedTicks + " ticks to throw an exception");
            }
            Console.WriteLine();
        }
        public static void Print(int[] arr)
        {
            foreach (int elem in arr)
                Console.Write(elem + "\t");
        }

    }

}
