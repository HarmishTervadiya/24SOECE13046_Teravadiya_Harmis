using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutotial3
{
    using System;

    class Clock
    {
        private int hour;
        private int min;
        private int sec;

        public Clock()
        {
            hour = 12;
            min = 0;
            sec = 0;
        }

        public Clock(int h, int m, int s)
        {
            hour = (h >= 0 && h < 24) ? h : 0;
            min = (m >= 0 && m < 60) ? m : 0;
            sec = (s >= 0 && s < 60) ? s : 0;
        }

        public void Tick()
        {
            sec++;
            if (sec == 60)
            {
                sec = 0;
                min++;
                if (min == 60)
                {
                    min = 0;
                    hour++;
                    if (hour == 24)
                    {
                        hour = 0;
                    }
                }
            }
        }
        public void Display()
        {
            Console.WriteLine($"{hour:D2}:{min:D2}:{sec:D2}");
        }

        public int GetHour()
        {
            return hour;
        }

        public int GetMinute()
        {
            return min;
        }

        public int GetSeconds()
        {
            return sec;
        }
    }


    internal class P2
    {
        static void Main()
        {
            Clock c1 = new Clock();
            Console.Write("Initial time (default): ");
            c1.Display();

            c1.Tick();
            Console.Write("After 1 tick: ");
            c1.Display();

            Clock c2 = new Clock(23, 59, 59);
            Console.Write("Initial time (custom): ");
            c2.Display();

            c2.Tick();
            Console.Write("After 1 tick: ");
            c2.Display();

            Console.WriteLine($"Hour: {c2.GetHour()}");
            Console.WriteLine($"Minute: {c2.GetMinute()}");
            Console.WriteLine($"Second: {c2.GetSeconds()}");
        }

    }

}
