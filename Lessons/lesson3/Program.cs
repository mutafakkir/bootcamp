using System;
using System.Linq;
using System.Collection.Gengeric;

namespace lesson3
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
            .Split(' ', StringSplitOptions.RemoveEmptyEntries)
            .Select(i => int.Parse(i))
            .ToList();

            int sum = 0;

            foreach(var son in numbers)
            {
                if(son <= 0) break;

                sum += son;
            }

            Console.WriteLine($"{sum}");    
        }
    }
}
