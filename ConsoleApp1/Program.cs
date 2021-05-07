using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            FotoWorker worker = new FotoWorker();
            worker.Start();

            Console.WriteLine("Hello World!");
        }
    }
}
