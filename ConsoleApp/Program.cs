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

            //MyFirstMethod();
            //PrintLine(SimpleMaths(valuesToSummate).ToString());
            //UseForLoop(valuesToSummate);
            ChangeStringToCharArray("Ik ben Jesse");
            BinarySearchDemo();

        }

        private static void BinarySearchDemo()
        {
            //show how it works
            //show without Array.Sort()
            int[] rank = { 224, 34, 156, 1023, -6 };
            //Array.Sort(rank);
            Console.WriteLine("What rank do you need?");
            int userInput = Convert.ToInt32(Console.ReadLine());

            int index = Array.BinarySearch(rank, userInput);
            if(index >= 0)
            {
                Console.WriteLine($"{userInput} found at index {index}");
            }
            else
            {
                Console.WriteLine("Not found in our array");
            }
        }

        private static void ChangeStringToCharArray(string v)
        {
            char[] charArray = v.ToCharArray();
            //let op met het gebruik van charArray.Length! 
            //length begint te tellen vanaf 1 terwijl de index telt vanaf 0!
            for(int i = 0; i < charArray.Length; i++)
            {
                Console.WriteLine(charArray[i]);
            }

            //foreach(var j in charArray)
            //{
            //    Console.WriteLine(j);
            //}

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