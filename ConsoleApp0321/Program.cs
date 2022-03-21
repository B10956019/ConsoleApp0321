using System;

namespace ConsoleApp0321
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();
            myCar.StartEngin();
            myCar.showInfo();
            Console.WriteLine("請輸入新顏色:");
            string i = Console.ReadLine();
            myCar.changeColor(i);
        }

    }
}
