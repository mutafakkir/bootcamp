using System;

namespace loop
{
    class Program
    {
        static void Main1() // Masalsa 1
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

        static void Main2() // Masala 2
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

        static void Main3() // Masala 3
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

        static void Main4() // Masal 4
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

        static void Main5() // Masala 5
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

        static void Main6() // Masala 6
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

        static void Main7() // Masala 7
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

        static void Main8() // Masala 8
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

        static void Main9() // Masala 9
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

        static void Main10() // Masala 10
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

        static void Main11() // Masala 11
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

        // static void Main12() // Masala 12
        // {
        //     int sum = 0; int N = int.Parse(Console.ReadLine());

        //     for(int i = 1; i <= N; i++)
        //     {
        //         sum += i;
        //     }
        //     Console.WriteLine(sum);
        // }

        // static void Main13() // Masala 13
        // {
        //     int sum = 0, cnt = 0;

        //     while(true)
        //     {
        //         string[] num = String.Empty;
        //         Int32.Parse(num);
                
        //         cnt ++;

        //         if(num <= 0)
        //         {
        //             System.Console.WriteLine($"{sum} {(sum / cnt + 1):F2} {cnt - 1}");
        //             break;
        //         }
        //         sum += num;
        //     }
        // }

        static void Main15() // Masala 15
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

        static void Main16() // Masala 16
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

       
        static void Main17() // Masala 17
        {
            int N;//число до которого будем находить простые числа
            N = int.Parse(Console.ReadLine());//вводим N
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
            bool tf=false;

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

        static void Main18() // Masala 18
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
    }
}

