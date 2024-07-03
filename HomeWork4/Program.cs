using System;

namespace HomeWork4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FirstTask();
        }


        public static void FirstTask()
        {
            for(int i = 1; i < 100; i += 2)
            {
                Console.WriteLine(i);
            }
        }
    }
}
