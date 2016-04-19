using System;
using System.Collections.Generic;
using System.Linq;

namespace GenericTypes
{
    class Program
    {
        static void Main()
        {
            int[] A = new[] {5, 8,10,12,15,5};
            A = RemoveNumberFromArray<int>(A, 12);
            string[] B = new[] {"A", "B", "C"};
            B = RemoveNumberFromArray<string>(B, "B");
            Console.WriteLine("Your are is:");
            ConsoleWriteArray(A);
            ConsoleWriteArray(B);
            List<Cow> list = new List<Cow>();
            Cow cow = new Cow("Tomi");
            list.Add(cow);

            Cow[] cows = new[] {new Cow("Molli"), new Cow("Bob"), new Cow("Tomi")};
            ConsoleWriteArray(cows);
            Console.WriteLine("Now we remove cow name TomI");
            cows = RemoveNumberFromArray(cows, new Cow("Tomi"));
            ConsoleWriteArray(cows);
            Console.WriteLine("HashCode");
            Cow cow1 = new Cow("Moli");
            Cow cow2 = new Cow("Moli");
            int a = 5;
            Console.WriteLine($"cow1 ={cow1.GetHashCode()}");
            Console.WriteLine($"cow2 ={cow2.GetHashCode()}");
            Console.WriteLine($"a ={a.GetHashCode()}");
            Console.ReadKey();




            /*
            //Second example
            int sc = MethodCreate<int>();
            string sb = MethodCreate<string>();
            char c = MethodCreate<char>();

            Console.WriteLine($"Type of sc{sc}");
            Console.WriteLine($"Type of sb {sb}");
            Console.WriteLine($"Type of c {c}");
            Console.ReadKey();
            */
        }

        private static T MethodCreate<T>()
        {
            return default(T);
        }

        private static void ConsoleWriteArray<T>(T[] A)
        {
            Console.Write("{");
            for (int i = 0; i < A.Length; i++)
            {
                Console.Write(A[i] + ",");
            }
            Console.WriteLine("}");
        }

        private static T[] RemoveNumberFromArray<T>(T[] inputArrayInts, T numberToRemove)
        {
            List<T> list = inputArrayInts.ToList();
            list.Remove(numberToRemove);
            return list.ToArray();
        }
    }

    internal class Cow
    {
        public string Name;

        public Cow(string molli)
        {
            Name = molli;
        }

        public override string ToString()
        {
            return $"Name: {Name}";
        }

        public override bool Equals(object obj)
        {
            if(obj is Cow)
                return Name == (obj as Cow).Name;
            return this.GetHashCode() == obj.GetHashCode();
        }
    }

    internal class SomeClass    
    {
    }
}
