using System;

namespace if_else
{
    class Program
    {
        static void Main1() // Malas 1
        {
            int b = int.Parse(Console.ReadLine());

            if(0 > b && b <= 40)
            {
                Console.WriteLine("Ichkarida o'yna");
            }

            else
            {
                Console.WriteLine("Tashqarida o'yna");
            }
        }

        static void Main2() // Masal 2
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            if(a * a == b)
            {
                Console.WriteLine($"{0} * {1} = {2}", a, a, b);
            }

            else if(b * b == a)
            {
                Console.WriteLine($"{0} * {1} = {2}", b, b, a);
            }

            else 
            {
                Console.WriteLine("none");
            }  
        }

        static void Main3() // Masala 3
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            if(a > b)
            {
                Console.WriteLine("{0}", a);
            }

            else
            {
                Console.WriteLine("{0}", b);
            }
        }

        static void Main4() // Masala 4
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            if(a > b && a > c && c > b)
            {
                Console.WriteLine("{0} {1}", a, b);
            }

            else if(a > b && a > c && b > c)
            {
                Console.WriteLine("{0} {1}", a, c);
            }

            else if(b > a && b > c && a > c)
            {
                Console.WriteLine("{0} {1}", b, c);
            }

            else if(b > a && b > c && c > a)
            {
                Console.WriteLine("{0} {1}", b, a);
            }

            else if(c > a && c > b && b > a)
            {
                Console.WriteLine("{0} {1}", c, a);
            }

            else if(c > a && c > b && a > b)
            {
                Console.WriteLine("{0} {1}", c, b);
            }
        }

        static void Main5() // Masala 5
        {
            int a = int.Parse(Console.ReadLine());

            if(a % 2 == 0 && a % 3 == 0 && a % 5 == 0)
            {
                Console.WriteLine("A");
            }

            else if(a % 2 == 0 && a % 3 == 0)
            {
                Console.WriteLine("B");
            }

            else if(a % 2 == 0 && a % 5 == 0)
            {
                Console.WriteLine("C");
            }

            else if(a % 3 == 0 && a % 5 == 0)
            {
                Console.WriteLine("D");
            }

            else if(a % 2 == 0 || a % 3 == 0 || a % 5 == 0)
            {
                Console.WriteLine("E");
            }

            else if(a % 2 != 0 && a % 3 != 0 && a % 5 != 0)
            {
                Console.WriteLine("N");
            }
        }

        static void Main6() // Masala 6
        {
            int a = int.Parse(Console.ReadLine());

            if(a % 4 != 0)
            {
                Console.WriteLine("Normal Year");
            }

            else if(a % 100 == 0 && a % 400 != 0)
            {
                Console.WriteLine("Normal Year");
            }

            else
            {
                Console.WriteLine("Leap Year");
            }
        }

        static void Main7() // Masala 7
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            if(b == a)
            {
                Console.WriteLine("correct");
            }

            else if(b > a)
            {
                Console.WriteLine("DOWN");
            }

            else
            {
                Console.WriteLine("UP");
            }

            int c = int.Parse(Console.ReadLine());

            if(c == a)
            {
                Console.WriteLine("correct");
            }

            else if(c > a)
            {
                Console.WriteLine("DOWN");
            }

            else
            {
                Console.WriteLine("UP");
            }
        }

        static void Main8() // Masala 8
        {
            char a = char.Parse(Console.ReadLine());

            if(Char.IsLower(a))
            {
                Console.WriteLine(Char.ToUpper(a));
            }

            else if(Char.IsUpper(a))
            {
                Console.WriteLine(Char.ToLower(a));
            }

            else
            {
                Console.WriteLine("none");
            }
        }

        static void Main9() // Masala 9
        {
            int x1 = int.Parse(Console.ReadLine());
            int x2 = int.Parse(Console.ReadLine());
            int x3 = int.Parse(Console.ReadLine());
            int y1 = int.Parse(Console.ReadLine());
            int y2 = int.Parse(Console.ReadLine());
            int y3 = int.Parse(Console.ReadLine());

            int x = 0;
            int y = 0;

            if(y1 == x1)
            {
                x++;
            }

            else if(y1 == x2 || y1 == x3)
            {
                y++;
            }

            if(y2 == x2)
            {
                x++;
            }

            else if(y2 == x1 || y2 == x3)
            {
                y++;
            }

            if(y3 == x3)
            {
                x++;
            }

            else if(y3 == x1 || y3 == x2)
            {
                y++;
            }
            Console.WriteLine("{0}S{1}B", x, y);
        }

        static void Main10() // Masala 10
        {
            int A = int.Parse(Console.ReadLine());
            char C = char.Parse(Console.ReadLine());
            int B = int.Parse(Console.ReadLine());

            if(C == '+')
            {
                Console.WriteLine("{0} + {1} = {2} ", A, B, A+B);
            }

            else if(C == '-')
            {
                Console.WriteLine("{0} - {1} = {2}", A, B, A-B);
            }
        }

        static void Main() // Masala 11 
        {
            int N = int.Parse(Console.ReadLine());
            int M = int.Parse(Console.ReadLine());
            int C = 0;

            switch(N)
            {
                case 1: Console.WriteLine("Americano");
                        C = M - 500; break;
                case 2: Console.WriteLine("Caffe Latte");
                        C = M - 400; break;
                case 3: Console.WriteLine("Lemon Tea");
                        C = M - 300; break;  
            }

            Console.WriteLine($"{C / 500} {C % 500 / 100}");
        }

        static void Main13() // Masala 13
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            if(a + b > 100)
            {
                Console.WriteLine("True");
            }

            else
            {
                Console.WriteLine("False");
            }
        }

        static void Main14() // Masala 14
        {

            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            if(a*a + b*b == c*c)
            {
                Console.WriteLine("true");
            }

            else if(a*a + c*c == b*b)
            {
                Console.WriteLine("true");
            }

            else if(b*b + c*c == a*a)
            {
                Console.WriteLine("true");
            }

            else
            {
                Console.WriteLine("false");
            }
        }

        static void Main15() // Masala 15
        {
            char e = char.Parse(Console.ReadLine());

            switch(e)
            {
                case '+':
                case '-':
                case '*':
                case '/':
                case '%':
                Console.WriteLine("true"); break;

                default:
                Console.WriteLine("false"); break;
            }
        }

        static void Main16() // Masala 16
        {
            int a = int.Parse(Console.ReadLine());

            switch(a)
            {
                case 0: Console.WriteLine("nol"); break;
                case 1: Console.WriteLine("bir"); break;
                case 2: Console.WriteLine("ikki"); break;
                case 3: Console.WriteLine("uch"); break;
                case 4: Console.WriteLine("to'rt"); break;
                case 5: Console.WriteLine("besh"); break;
                case 6: Console.WriteLine("olti"); break;
                case 7: Console.WriteLine("yetti"); break;
                case 8: Console.WriteLine("sakkiz"); break;
                case 9: Console.WriteLine("to'qiz"); break;

                default: Console.WriteLine("boshqa"); break;
            }
        }

        static void Main17() // Masala 17
        {
            int s = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int n;

            if(s == 0)
            {
                s = 24;
            }
            
            n = s * 60 + m - 45;

            Console.WriteLine("{0}:{1}", n / 60, n % 60);
        }

        static void Main18() // Masala 18
        {
            int N = int.Parse(Console.ReadLine());

            if(N >= 90 && N <= 100)  
            {
                Console.WriteLine("A");
            }

            else if(N >= 80 && N < 90)
            {
                Console.WriteLine("B");
            }

            else if(N >= 70 && N < 80)
            {
                Console.WriteLine("C");
            }

            else if(N >= 60 && N < 70)
            {
                Console.WriteLine("D");
            }

            else if(N >= 50 && N < 60)
            {
                Console.WriteLine("F");
            }
        }

        static void Main19() // Masala 19
        {
            int N = int.Parse(Console.ReadLine());

            int ming = N / 100 % 10;
  
            Console.WriteLine(N = ming < 5 ? N / 1000 * 1000 : (N / 1000 + 1) * 1000);
        }

        static void Main20() // Masala 20
        {
            char N = char.Parse(Console.ReadLine());

            if(N >= 'A' && N <= 'Z')
            {
                Console.WriteLine("1");
            }

            else if(N >= 'a' && N <= 'z')
            {
                Console.WriteLine("1");
            }

            else
            {
                Console.WriteLine("0");
            }
        }

        static void Main21() // Masala 21
        {
            int N = int.Parse(Console.ReadLine());

            Console.WriteLine(N % 2 == 0 ? "even" : "odd");
        }
    }
}