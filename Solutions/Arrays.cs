using System;
using System.Linq;
using System.Collections.Generic;

namespace bootcamp.Solutions
{
    class Arrays
    {
        public void Problem1()
        {
            int i,n;
            int[] a= new int[100];

            Console.Write("Input the number of elements to store in the array: ");
            n = Convert.ToInt32(Console.ReadLine());    
            
            for( i = 0; i < n; i++ )
            {
                Console.Write($"element - {i + 1} : ");
                a[i] = Convert.ToInt32(Console.ReadLine()); 
            }
            
            Console.Write("Reversed: ");
            for( i = n - 1; i >= 0; i--)
            {
                Console.Write($"{a[i]} ");
            }
            Console.WriteLine();
        }

        public void Problem2()
        {
            int[] N = new int[5];
            float sum = 0;

            for( int i = 0; i < 5; i++)
            {
                N[i] = int.Parse(Console.ReadLine());
                sum += N[i];
            }

            float avarage = sum / 5;

            for( int i = 0; i < 5; i++ )
            {
                if(N[i] > avarage)
                {
                    Console.Write($"{N[i]} ");
                }
            }
        }

        public void Problem3()
        {
            int[] N = new int[5];

            for(int i = 0; i < 5; i++)
            {
                N[i] = int.Parse(Console.ReadLine());
            }

            for(int i = 0; i < 5 - 1; i++)
            {
                if(N[i] > N[i + 1])
                {
                    int temp = N[i];
                    N[i] = N[i + 1];
                    N[i + 1] = temp;
                }
            }
            
            for(int i = 0; i < 5; i++)
            {
                Console.WriteLine($"{N[i]}");
            }
        }

        public void Problem4()
        {
            int[] N = new int[10];
            int one = 0, two = 0, three = 0;

            for(int i = 0; i < 10; i++)
            {
                N[i] = int.Parse(Console.ReadLine());
            }

            for(int i = 0; i < 10; i++)
            {
                if(N[i] % 10 == 1)
                {
                    one++;
                }
            }

            for(int i = 0; i < 10; i++)
            {
                if(N[i] % 10 == 2)
                {
                    two++;
                }
            }

            for(int i = 0; i < 10; i++)
            {
                if(N[i] % 10 == 3)
                {
                    three++;
                }
            }

            Console.Write("1: ");
            for(int j = 0; j < one; j++)
            {
                Console.Write("*");
            }
            System.Console.WriteLine();

            Console.Write("2: ");
            for(int j = 0; j < two; j++)
            {
                Console.Write("*");
            }
            System.Console.WriteLine();

            Console.Write("3: ");
            for(int j = 0; j < three; j++)
            {
                Console.Write("*");
            }
            System.Console.WriteLine();
        }

        public void Problem5()
        {
            int[] array = new int[] { 2, 3, 5 };
        
            List<int> copied = new List<int>(array);
            
            Console.WriteLine("COPIED COUNT: {0}", copied.Count);
        }
    }
}