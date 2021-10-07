using System;

namespace bootcamp.Solutions
{
    class Lab3
    {
        public void Problem1()
        {
            System.Console.Write("Sonni kriting: ");
            var line = Console.ReadLine();
            var data = line.Split(' ');
            var a = int.Parse(data[0]);
		    char ch = (char)a;

            System.Console.WriteLine($"Natija (int): {a}");
		    Console.WriteLine($"Natija (char): {ch}");
        }

        public void Problem2()
        {
            System.Console.Write("Enter width: ");
            int b = int.Parse(Console.ReadLine());

            System.Console.Write("Enter lenght: ");
            int a = int.Parse(Console.ReadLine());

            var c = a * b;
            System.Console.WriteLine($"Area is {c}");
        }

        public void Problem3()
        {
            System.Console.Write("Enter width: ");
            float b = float.Parse(Console.ReadLine());

            System.Console.Write("Enter lenght: ");
            float a = float.Parse(Console.ReadLine());

            var c = a * b;
            System.Console.WriteLine($"Area is {c}");
        }

        public void Problem4()
        {
            System.Console.Write("Enter a real number: ");
            float b = float.Parse(Console.ReadLine());

            int a = (int)Math.Round(b);
            System.Console.Write($"Round off: {a}");
        }

        public void Problem5()
        {
            System.Console.Write("Enter lower case:");
            char a = char.Parse(Console.ReadLine());

            if(Char.IsLower(a))
            {
                System.Console.Write("Upper case: ");
                Console.WriteLine(Char.ToUpper(a));
            }
        }

        public void Problem6()
        {
            System.Console.Write("Enter upper case:");
            char a = char.Parse(Console.ReadLine());

            if(Char.IsUpper(a))
            {
                System.Console.Write("Lower case: ");
                Console.WriteLine(Char.ToLower(a));
            }
        }
    }
}   