using System;

namespace ConsoleApp2
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            TemperatuurMeting eenMeting = new TemperatuurMeting();
            eenMeting.Temperatuur = 3.4;
            eenMeting.IsGeconfirmeerd = true;
        }
    }
}