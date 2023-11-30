using System;
using System.Threading;
using System.Threading.Tasks; 

namespace MultiThreading
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Thread thread = new Thread(PrintText);
            thread.Start();
        }
        static void PrintText()
        {
            string a = "Salam";
            for (int i = 0; i < a.Length; i++)
            {
                Thread.Sleep(1000);
                Console.Write(a[i]);
            }
        }
    }
}
