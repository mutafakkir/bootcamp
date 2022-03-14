using System;
using System.Linq;

namespace lesson8
{
    class Program
    {
        static void Main(string[] args)
        {
            var sonlar = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, };
            var g = sonlar
                .OrderByDescending(i => i % 3)
                .Select(i => { Console.Write($"{i} "); return i; })
                .ToArray();
        }
    }
} 