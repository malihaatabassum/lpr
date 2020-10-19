using System;

namespace lab1t1
{
    class Program
    {
        static void Main(string[] args)
        { //task1 
            Console.WriteLine("Hello");
            Console.WriteLine("Maliha Tabassum");



            //task2 
            int x = 1;
            int y = 2;
            int sum = x + y;
            Console.Writeline(sum);


            //task3
            int x = 2;
            int y = 6;
            int division = y / x;
            Console.Writeline(division);


            //task4
            System.Console.WriteLine(-5 + 8 * 6);
            //-5+(8X6)=-5+48=43

            System.Console.WriteLine((55 + 9) % 9);
            //64/9=7.111

            System.Console.WriteLine(20 + -3 * 5 / 8);
            //20-15/8= 18.125

            System.Console.WriteLine(5 + 15 / 3 * 2 - 8 % 3);
            //5+10-8/3=12.334



            //task5
            int x = 10;
            int y = 20;
            int sum = x + y;
            int mul = y*x;
            int sub = x - y;
            int div = y / x;


            //task6
            System.Console.WriteLine((25.5 * 3.5 - 3.5 * 3.5) / (40.5 - 4.5));
            //(89.25-12.25)/36=2.14

            //task7
            int area,
             int length=2,
                int width=3;
            Console.Write("length: ");
            Console.Write("width: ");
           area = length * width;
            Console.WriteLine("The area of rectangle is:", area);

        }
    }
}
