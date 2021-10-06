using System;
using System.Linq;
using lesson1.Solutions;

namespace lesson1
{
    class Program
    {
        static void Main()
        {
            System.Console.WriteLine("Choose Lab(2, 3, 4): ");
            var line = Console.ReadLine();
            var data = line.Split(' ');
            var a = int.Parse(data[0]);
            
            if(a == 2)
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

            else if(a == 3)
            {
                var lab3 = new Lab3();
                lab3.Problem1();
                lab3.Problem2();
                lab3.Problem3();
                lab3.Problem4();
                lab3.Problem5();
                lab3.Problem6();
            }

            else if(a == 4)
            {
                var lab4 = new Lab4();
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

            else if(a == 5)
            {   
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
                lab4.Problem11();
                lab4.Problem13();
                lab4.Problem14();
                lab4.Problem15();
                lab4.Problem16();
                lab4.Problem17();
                lab4.Problem18();
                lab4.Problem19();
                lab4.Problem20();
                lab4.Problem21();
            }
        }
    }
}
