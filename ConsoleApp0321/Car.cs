using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp0321
{
    class Car
    {
        string color = "red";
        int cc = 1500;
        string brand = "BMW";
        public void StartEngin()
        {
            Console.WriteLine("發動引擎");
        }

        public void showInfo()
        {
            Console.WriteLine("顏色: " + color);
            Console.WriteLine("cc: " + cc);
            Console.WriteLine("品牌: " + brand);
        }
        public void changeColor(string n)
        {
            color = n;
            Console.WriteLine("新顏色: " + color);
        }
    }
   
}
