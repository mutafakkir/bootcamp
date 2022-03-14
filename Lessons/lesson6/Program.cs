using System;

namespace lesson6
{
    class Program
    {
        static void Main(string[] args)
        {
            var t = int.Parse(Console.ReadLine());

            while(t-->0)
            {
                System.Console.WriteLine(new Prince().Travel());
            }
        }
    }
}
