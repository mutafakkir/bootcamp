﻿using System;
using System.Linq;
using bootcamp.Solutions;

namespace bootcamp
{
    class Program
    {
        static void Main()
        {
            System.Console.WriteLine("Choose Lab(2, 3, 4, 5, 6, 7): ");
            int a = int.Parse(Console.ReadLine());

            if (a == 2)
            {
                var lab2 = new Lab2();
                lab2.Problem1();
                lab2.Problem2();
                lab2.Problem3();
                lab2.Problem4();
                lab2.Problem5();
                lab2.Problem6();
                lab2.Problem7();
                lab2.Problem8();
                lab2.Problem9();
            }
            else if (a == 3)
            {
                var lab3 = new Variables();
                lab3.Problem1();
                lab3.Problem2();
                lab3.Problem3();
                lab3.Problem4();
                lab3.Problem5();
                lab3.Problem6();
            }
            else if (a == 4)
            {
                var lab4 = new Expressions();
                lab4.Problem1();
                lab4.Problem2();
                lab4.Problem3();
                lab4.Problem4();
                lab4.Problem5();
                lab4.Problem6();
                lab4.Problem7();
                lab4.Problem8();
                lab4.Problem9();
                lab4.Problem10();
            }
            else if (a == 5)
            {
                var lab5 = new Conditionals();
                lab5.Problem1();
                lab5.Problem2();
                lab5.Problem3();
                lab5.Problem4();
                lab5.Problem5();
                lab5.Problem6();
                lab5.Problem7();
                lab5.Problem8();
                lab5.Problem9();
                lab5.Problem10();
                lab5.Problem11();
                lab5.Problem13();
                lab5.Problem14();
                lab5.Problem15();
                lab5.Problem16();
                lab5.Problem17();
                lab5.Problem18();
                lab5.Problem19();
                lab5.Problem20();
                lab5.Problem21();
            }
            else if (a == 6)
            {
                var lab6 = new Loops();
                lab6.Problem1();
                lab6.Problem2();
                lab6.Problem3();
                lab6.Problem4();
                lab6.Problem5();
                lab6.Problem6();
                lab6.Problem7();
                lab6.Problem8();
                lab6.Problem9();
                lab6.Problem10();
                lab6.Problem11();
                lab6.Problem13();
                lab6.Problem14();
                lab6.Problem15();
                lab6.Problem16();
                lab6.Problem17();
                lab6.Problem18();
                lab6.Problem19();
                lab6.Problem20();
                lab6.Problem21();
                lab6.Problem22();
                lab6.Problem23();
                lab6.Problem24();
            }

            else if (a == 7)
            {
                var array = new Arrays();
                array.Problem5();
            }
        }
    }
}
