using System;
using System.Collections.Generic;
using System.Linq;
using System.Text; 

namespace Clock
{
    class Clock
    {
        static void Main(string[] args){
            int h = -1;
            int m = -1;
            do {
                string[] time = Console.ReadLine().Split(' ');
                try
                {
                    h = Convert.ToInt32(time[0]);
                    m = Convert.ToInt32(time[1]);
                }
                catch (Exception e) { }
            } while (h > 23 | h < 0 | m > 59 | m < 0);

            Console.WriteLine((((float)(h * 60 + m)) * 5.5f) % 180);
            Console.ReadLine();
        }
    }
}
