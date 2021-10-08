using System;
using System.Linq;

namespace bootcamp.Solutions
{
    class Loops
    {
        public void Problem1()
        {
            int a = int.Parse(Console.ReadLine());

            for(int i = 1; i <= a; i++)
            {
                if(a % i == 0)
                {
                    Console.Write($"{i} ");
                }
            }   
        }

        public void Problem2()
        {
            int a = int.Parse(Console.ReadLine());

            for(int i = 1; ; i++)
            {
                int b = int.Parse(Console.ReadLine());

                if(b == a)
                {
                    Console.WriteLine($"{i}ta urunish"); break;
                }

                else if(b > a)
                {
                    Console.WriteLine($"{b}>");
                }

                else
                {
                    System.Console.WriteLine($"{b}<");
                }
            }
        }

        public void Problem3()
        {
            int sum = 0;

            while(true)
            {
                int son = int.Parse(Console.ReadLine());
                if(son == 0)
                {
                    break;
                }

                else
                {
                    sum += son;
                }
            }

            Console.WriteLine(sum);
        }

        public void Problem4() // Masal 4
        {
            for(int i = 2; i <= 10; i++)
            {
                int fact = i;
                System.Console.Write($"{i}!=");

                for(int k = 1; k < i; k++)
                {
                    Console.Write($"{k}*");
                    fact *= k;
                }
                Console.WriteLine($"{i}={fact}");
            }
        }

        public void Problem5()
        {
            string[] tokens = Console.ReadLine().Split();

            int a = int.Parse(tokens[0]);
            int b = int.Parse(tokens[1]);

            for (int i = a; i > 0; i--)
            {
                if (a % i == 0)
                {
                    if (b % i == 0)
                    {
                        Console.WriteLine(i);
                        break;
                    }
                }
            }
        }

        public void Problem6()
        {
            int lines = int.Parse(Console.ReadLine());
            
            for(int i = 1; i <= lines; i++)
            {
                int spaces = lines - 1;
                while(spaces > 0)
                {
                    Console.Write(" ");
                    spaces--;
                }

                int stars = i * 2 - 1;
                while(stars > 0)
                {
                    Console.Write("*");
                    stars--;
                }
                System.Console.WriteLine();
            }

            for(int i = lines - 1; ;i--)
            {
                int spaces = lines - i;
                while(spaces > 0)
                {
                    Console.Write(" ");
                    spaces--;
                }

                int stars = i * 2 - 1;
                while(stars > 0)
                {
                    Console.Write("*");
                    stars--;
                }
                Console.WriteLine();
            }
        }

        public void Problem7()
        {
            for(int i = 1; i <= 10; i++)
            {
                for(int k = i; k <= (i + 9); k++)
                {
                    Console.Write("{0} ", k % 10);
                }
                System.Console.WriteLine();
            }
        }

        public void Problem8()
        {
            int count = 0;
            int num = int.Parse(Console.ReadLine());

            for(int i = 1; i <= num; i++)
            {
                int m = i;
                while(m > 0)
                {
                    if(m % 10 == 3)
                    {
                        count++;
                    }
                    m /= 10;
                }
            }
            Console.WriteLine(count);
        }

        public void Problem9()
        {
            int num = 1; int number = int.Parse(Console.ReadLine());

            for(int i = 1; i <= number; i++)
            {
                int spaces = number - 1;
                while(spaces > 0)
                {
                    Console.Write(" ");
                    spaces--;
                }

                for(int k = 1; k <= i; k++)
                {
                    Console.Write("{0} ", num % 10);
                    num++;
                }
                System.Console.WriteLine();
            }
        }

        public void Problem10()
        {
            int num = int.Parse(Console.ReadLine());

            while(num > 0)
            {
                int sum = 0;
                while(num > 0)
                {
                    sum += num % 10;
                    num /= 10;
                }

                num = sum;

                if(num < 10)
                {
                    break;
                }
            }
            Console.Write(num);
        }

        public void Problem11()
        {
            for(int i = 1; i <= 6; i++)
            {
                for(int k = 1; k <= 6; k++)
                {
                    for(int j = 1; j <= 6; j++)
                    {
                        if(i + k + j == 10)
                        {
                            Console.Write($"{i} {k} {j}");
                        }        
                    }
                    Console.WriteLine();
                }
            }
        }

        public void Problem12()
        {
            int sum = 0; int N = int.Parse(Console.ReadLine());

            for(int i = 1; i <= N; i++)
            {
                sum += i;
            }
            Console.WriteLine(sum);
        }

        public void Problem13()
        {
            var numbers = Console.ReadLine()
            .Split(' ', StringSplitOptions.RemoveEmptyEntries)
            .Select(i => int.Parse(i))
            .ToList();

            int sum = 0;

            foreach (var son in numbers)
            {
                if(son <= 0) break;

                sum += son;
            }

            Console.WriteLine($"{sum}");
        }

        public void Problem14()
        {
            int I = 1; int Y = 0;

            int N = int.Parse(Console.ReadLine());

            string[] token = Console.ReadLine().Split();

            while(I <= N)
            {
                if(N >= 2 && N <= 10)
                {
                    I++;
                    int X = int.Parse(token[0]);
                    Y += X * X * X;
                }
            } 
            Console.WriteLine(Y);
        }

        public void Problem15()
        {
            int son = int.Parse(Console.ReadLine());
            int sum = 1;

            for(int i = 1; i <= 13; i++)
            {
                sum *= i;

                if(sum == son)
                {
                    Console.WriteLine("True"); break;
                }
            }

            if(son != sum)
            {
                Console.WriteLine("False");
            }
        }

       
        public void Problem16()
        {
            int N = int.Parse(Console.ReadLine());

            for (int i = 2; i <= N; i++)
            {
                if (isSimple(i))
                {
                    Console.Write(i.ToString()+",");
                }
            }
        }

        private static bool isSimple(int N)
        {
            bool tf = false;

            for (int i = 2; i < (int)(N / 2); i++)
            {
                if (N % i == 0)
                {
                    tf = false;
                    break;
                }
                else
                {
                    tf = true;
                }
            }
                return tf;
        }

        public void Problem17() 
        {
            int x = 0; int y = 0;

            int num = int.Parse(Console.ReadLine());

            for(int i = 1; i <= num; i++)
            {
                string[] token = Console.ReadLine().Split();
                int step = int.Parse(token[0]);
                int j = i % 4;

                switch(j)
                {
                    case 1: y += step; break;
                    case 2: x += step; break;
                    case 3: y -= step; break;
                    case 0: x -= step; break;
                }
            }
            Console.WriteLine($"{x} {y}");
        }

        public void Problem18()
        {
            long a = int.Parse(Console.ReadLine());
            long b = int.Parse(Console.ReadLine());

            long aCopy = a;
            long bCopy = b;

            int cycles = 0;

            while(a != 1 && b != 1)
            {
                if(a % 2 == 0)
                {
                    a /= 2;
                }
                else
                {
                    a = a * 3 + 1;
                }

                if(b % 2 == 0)
                {
                    b /= 2;
                }
                else
                {
                    b = b * 3 + 1;
                }

                cycles++;
            }

            if(a == 1)
            {
                System.Console.WriteLine($"{aCopy} {cycles}");
            }
            else
            {
                System.Console.WriteLine($"{bCopy} {cycles}");
            }
        }

        public void Problem19()
        {
            int N = int.Parse(Console.ReadLine());

            while(N >= 1 && N <= 50)
            {
                long f1 = 0;
                long f2 = 1;

                long output = f1 + f2;

                if(N > 0)
                {
                    for(int i = 3; i <= N; i++)
                    {
                        output = f1 + f2;
                        f1 = f2;
                        f2 = output;
                    }
                }
                System.Console.WriteLine(output); break;
            }
        }

        public void Problem20()
        {
            int sikl(int n)
            {
                return n % 10 * 10 + (n / 10 + n % 10) % 10;
            }

            int k, s = 0;
            int n = int.Parse(Console.ReadLine());
            k = n;
            do
            {
                s++;
                n = sikl(n);
            }
            while(k != n);
            Console.WriteLine(s);
        }

        public void Problem21()
        {
            long palindrom(long son) 
            {
                long result = 0;

                while(son > 0)
                {
                    result = son % 10 + (result * 10);
                    son /= 10;
                }
                return result;
            }

            long n = int.Parse(Console.ReadLine());
            int count = 0;

            while(n != palindrom(n))
            {
                n = n + palindrom(n);
                count++;
            }

            Console.WriteLine($"{count} {n}");
        }

        public void Problem22()
        {
            int num = int.Parse(Console.ReadLine());

            for (long i = 0; i <= num; i++) 
            { 
                long n = 0;
                double sum = 0; 
                long temp = i; 

                while ( temp != 0 ) 
                { 
                    ++n;
                    temp /= 10; 
                } 

                temp = i; 
                while ( temp != 0 ) 
                { 
                    long r = temp % 10; 
                    sum += Math.Pow(r, n);
                    temp /= 10; 
                } 

                if ( i == sum ) 
                {
                    Console.WriteLine($"{i} "); 
                    sum = 0; 
                }
            }
        }

        public void Problem23()
        {
            int cnt = 1;
            int n = int.Parse(Console.ReadLine());

            while(n > 0)
            {
                if(n == n / 10)
                {   
                    cnt ++;
                }
            }
        }

        public void Problem24()
        {
            int N = int.Parse(Console.ReadLine());

            for(int i = 1; i <= N; i++)
            {
                for(int j =1; j <= i; j++)
                {
                System.Console.Write("*");
                }
                System.Console.WriteLine();
            }
        }
    }
}    
