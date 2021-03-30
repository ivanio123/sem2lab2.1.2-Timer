using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace sem2._7._1._2_Timer_
{
    class Program
    {
        delegate void Delegate(int sec);

        public delegate void Methods();
        static void Main(string[] args)
        {
            Console.Write("Введiть кiлькiсть секунд: ");
            int sec = int.Parse(Console.ReadLine());
            Timer timer = new Timer();
            Delegate del = timer.Start;
            del.Invoke(sec);
        }
    }
}
