using System;

namespace lesson2
{
    class Program
    {
        static void Main(string[] args)
        {
            int? a = null;
            string hechnima = string.Empty;

            if(hechnima is null)
            {
                System.Console.WriteLine("Hechnima null ga teng");
            }

            else
            {
                System.Console.WriteLine($"Hechnima {hechnima} ga teng");
            }

            int son = int.Parse(Console.ReadLine());

            switch(son)
            {
                case 1: System.Console.WriteLine("Siz bir kiritingiz"); break;
                case 2: System.Console.WriteLine("Siz ikki kiritingiz"); break;
                case 3: System.Console.WriteLine("Siz uch kiritingiz"); break;
                case 4: System.Console.WriteLine("Siz to'rt kiritingiz"); break;
                _ : System.Console.WriteLine($"Siz {son} kiritingiz"); break;
            }

            var message = son switch;
            {
                1 => "Siz bir kiritdingiz!"
                2 => "Siz ikki kiritdingiz!"
                3 => "Siz uch kiritdingiz!"
                4 => "Siz four kiritdingiz!"
                _ => $"Siz {son} kiritdingiz!"
            };

            var message = son switch
            {
                > 0 => "Siz musbat son kiritdingiz",
                (< 0) => "Siz manfiy son kiritdingiz",
                _ => "Siz nol kiritdingiz",
            };

            System.Console.WriteLine(message);
        }
    }
}
