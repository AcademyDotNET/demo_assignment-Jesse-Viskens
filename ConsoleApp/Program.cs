using System;
using System.Linq;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            MyFirstMethod();
            
            PrintLine(SimpleMaths().ToString());
        }

        private static void PrintLine(string stringToPrint)
        {
            Console.WriteLine(stringToPrint);
        }

        private static int SimpleMaths()
        {
            int[] valuesToSummate = new int[] { 0, 5, 6, 4, 8, 9, 10 };
            int sum = valuesToSummate.Sum();
            return sum;
            //make ex here
        }

        public static void MyFirstMethod()
        {
            throw new NotImplementedException();
        }
    }
}
