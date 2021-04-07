using System;
using System.Linq;

namespace ConsoleApp
{
    internal class Program
    {
        public static void MyFirstMethod()
        {
            throw new NotImplementedException();
        }
        private static void Main(string[] args)
        {
            int[] valuesToSummate = new int[] { 0, 5, 6, 4, 8, 9, 10 };

            MyFirstMethod();
            PrintLine(SimpleMaths(valuesToSummate).ToString());
            UseForLoop(valuesToSummate);
            DoSomething();

            DoSomethingElse(101);
            DoSomethingElse(500);
            DoSomething();
        }

        private static void DoSomethingElse(int i)
        {
            Console.WriteLine(i);
        }

        private static void DoSomething()
        {
            Console.WriteLine("tst");
            throw new NotImplementedException();
        }

        private static void UseForLoop(int[] valuesToSummate)
        {
            for (int i = 0; i <= valuesToSummate.Length; i++)
            {

                Console.WriteLine(valuesToSummate[i]);
            }
        }

        private static void PrintLine(string stringToPrint)
        {
            Console.WriteLine(stringToPrint);
        }

        private static int SimpleMaths(int[] valuesToSummate)
        {
            int sum = valuesToSummate.Sum();
            return sum;
        }


    }
}