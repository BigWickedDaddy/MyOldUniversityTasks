using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Домашка2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Введите время в формате 12:34:56 ");

            string time = Console.ReadLine();
            string[] splitTime = time.Split(new char[] { ':' });

            int hours = Convert.ToInt32(splitTime[0]);
            int minutes = Convert.ToInt32(splitTime[1]);
            int seconds = Convert.ToInt32(splitTime[2]);
            double a,b,c, hours1, minutes1, seconds1;
            a = 0.5;
            b = 6;
            c = 6;
            hours1 = hours * a * 60;
            minutes1 = minutes*b;
            seconds1 = seconds * c;
            Console.WriteLine("Градусы между 12 часами и стрелками : " + hours1 + " " + minutes1 + " " + seconds1);
            Console.ReadKey();
            double n=0, m=0, k=0;
            if (hours1 > seconds1)
                n = hours1 - seconds1;
            else n = seconds1 - hours1;
            if (hours1 > minutes1)
                m = hours1 - minutes1;
            else m = minutes1 - hours1;
            if (seconds > minutes1)
                k = seconds1 - minutes1;
            else k = minutes1 - seconds1;
            Console.WriteLine("   1)" + n + "   2)" + m + "   3)" + k);
            DateTime timeNow = DateTime.Now;
            string timeNowString = timeNow.ToLongTimeString();

            Console.WriteLine(timeNow.ToLongTimeString());

            string[] timeSplitNow = timeNowString.Split(new char[] { ':' });

            int hoursNow = Convert.ToInt32(timeSplitNow[0]);
            int minutesNow = Convert.ToInt32(timeSplitNow[1]);
            int secondsNow = Convert.ToInt32(timeSplitNow[2]);
            hours1 = hoursNow * a * 60;
            minutes1 = minutesNow * b;
            seconds1 = secondsNow * c;
            Console.WriteLine("Градусы между 12 часами и стрелками : " + hours1 + " " + minutes1 + " " + seconds1);
            Console.ReadKey();
            hours1 = 0;
            minutes1 = 0;
            seconds1 = 0;
            n = 0;
            m = 0;
            k = 0;
            hours1 = hoursNow * a * 60;
            minutes1 = minutesNow * b;
            seconds1 = secondsNow * c;
            if (hours1 > seconds1)
                n = hours1 - seconds1;
            else n = seconds1 - hours1;
            if (hours1 > minutes1)
                m = hours1 - minutes1;
            else m = minutes1 - hours1;
            if (seconds > minutes1)
                k = seconds1 - minutes1;
            else k = minutes1 - seconds1;
            Console.WriteLine("   1)" + n + "   2)" + m + "   3)" + k);
            Console.ReadKey();

        }

    }
}