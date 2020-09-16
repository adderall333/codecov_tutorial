using System;

namespace codecov_tutorial
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public static int Method1(int a, int b)
        {
            return a + b;
        }
        
        public static int Method2(int a, int b)
        {
            if (a > b)
                return a;
            else
                return b;
        }
    }
}