using System;

namespace bootcamp.Solutions
{
    class Lab4
    {
        public void Problem1()
        {
            int N = int.Parse(Console.ReadLine());
            System
                .Console
                .WriteLine($"{N / 10000}!{(N / 1000) % 10}!{(N / 100) % 10}!{
                    (N / 10) % 10}!{N % 10}");
        }

        public void Problem2()
        {
            int N = int.Parse(Console.ReadLine());
            int hours = N / 3600;
            int minutes = N % 3600 / 60;
            N = N % 60;

            string h = hours.ToString().PadLeft(2, '0');
            string m = minutes.ToString().PadLeft(2, '0');
            string n = N.ToString().PadLeft(2, '0');

            System.Console.WriteLine($"{h}:{m}:{n}");
        }

        public void Problem3()
        {
            int N = int.Parse(Console.ReadLine());

            int target = N / 100 % 10;
            N = target <= 5 ? N / 1000 * 1000 : (N / 1000 + 1) * 1000;
            System.Console.WriteLine (target);
        }

        public void Problem4()
        {
            int N = int.Parse(Console.ReadLine());
            int target = N / 100 % 10;

            if (target < 5)
            {
                System.Console.WriteLine($"{N / 1000 * 1000}");
            }
            else if (target > 5)
            {
                System.Console.WriteLine($"{(N / 1000 + 1) * 1000}");
            }
        }

        public void Problem5()
        {
            double P = 3.14;
            float N = float.Parse(Console.ReadLine());

            double radius = N / (2 * P);
            double S = P * radius * radius;

            int b = (int) Math.Round(S);

            System.Console.WriteLine($"{b}");
        }

        public void Problem6()
        {
            int N = int.Parse(Console.ReadLine());

            if (N >= 20 && N <= 30)
            {
                System.Console.WriteLine("1");
            }
            else
            {
                System.Console.WriteLine("0");
            }
        }

        public void Problem7()
        {
            char N = char.Parse(Console.ReadLine());

            if (N >= 65 && N <= 90)
            {
                System.Console.WriteLine("1");
            }
            else if ((N >= 97 && N <= 122))
            {
                System.Console.WriteLine("1");
            }
            else
            {
                System.Console.WriteLine("0");
            }
        }

        public void Problem8()
        {
            int N = int.Parse(Console.ReadLine());

            Console.WriteLine(N % 2 == 0 ? "even" : "odd");
        }

        public void Problem9()
        {
            int N = int.Parse(Console.ReadLine());
            int M = int.Parse(Console.ReadLine());

            if (N > M)
            {
                System.Console.WriteLine($"{N}");
            }
            else if (N < M)
            {
                System.Console.WriteLine($"{M}");
            }
        }

        public void Problem10()
        {
            int N = int.Parse(Console.ReadLine());
            int M = int.Parse(Console.ReadLine());

            if (N > M)
            {
                System.Console.WriteLine($"{N / M}");
                System.Console.WriteLine($"{N % M}");
            }
            else if (N < M)
            {
                System.Console.WriteLine($"{M / N}");
                System.Console.WriteLine($"{M % N}");
            }
        }
    }
}
