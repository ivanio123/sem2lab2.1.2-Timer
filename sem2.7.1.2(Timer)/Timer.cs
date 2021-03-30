using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using static sem2._7._1._2_Timer_.Program;

namespace sem2._7._1._2_Timer_
{
    class Timer
    {
        public void Start(int sec)
        {
            Methods[] methods = new Methods[] { MethodOne, MethodTwo, MethodThree };
            Random rand = new Random();
            while (true)
            {
                Thread.Sleep(sec * 1000);
                int i = rand.Next(0, 3);
                methods[i]();
            }
        }
        private static void MethodOne()
        {
            Console.WriteLine("Метод 1.");
        }
        private static void MethodTwo()
        {
            Console.WriteLine("Метод 2.");
        }
        private static void MethodThree()
        {
            Console.WriteLine("Метод 3.");
        }
    }
}
