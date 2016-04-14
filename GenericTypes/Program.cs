using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace GenericTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] A = new[] {5, 8,10,12,15,5};
            A = RemoveNumberFromArray<int>(A, 12);
            string[] B = new[] {"A", "B", "C"};
            B = RemoveNumberFromArray<string>(B, "B");
            Console.WriteLine("Your are is:");
            ConsoleWriteArray(A);
            Console.WriteLine();
            ConsoleWriteArray(B);
            Console.ReadKey();


        }

        private static void ConsoleWriteArray<T>(T[] A)
        {
            Console.Write("{");
            for (int i = 0; i < A.Length; i++)
            {
                Console.Write(A[i] + ",");
            }
            Console.Write("}");
        }

        private static T[] RemoveNumberFromArray<T>(T[] inputArrayInts, T numberToRemove)
        {
            List<T> list = inputArrayInts.ToList();
            list.Remove(numberToRemove);
            return list.ToArray();
        }
    }
}
