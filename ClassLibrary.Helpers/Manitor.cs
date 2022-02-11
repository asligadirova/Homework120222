using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Helpers
{
    public class Manitor
    {
        public static string ReadString(string caption)
        {
            Console.Write(caption);
            Console.ForegroundColor = ConsoleColor.Green;
            string aStr = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.White;

            return aStr;

        }
        public static DateTime ReadDateTime(string caption)
        {
        l1:
            Console.Write(caption);
            Console.ForegroundColor = ConsoleColor.Green;
            string aStr = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.White;
            if (!DateTime.TryParseExact(aStr, "yyyy.MM.dd", null, DateTimeStyles.None, out DateTime date))
            {
                Manitor.PrintError("Yeniden daxil edin");
                goto l1;
            }

            return date;

        }

        public static double DoubleEdedOxu(string msg)

        {
        l1:
            Console.Write(msg);
            Console.ForegroundColor = ConsoleColor.Blue;
            string aStr = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.White;

            double a;
            try
            {
                a = Convert.ToDouble(aStr);

            }
            catch
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("yeniden daxil edin");
                Console.ForegroundColor = ConsoleColor.White;
                goto l1;
            }
            return a;

        }
        public static int IntEdedOxu(string msg)

        {
        l1:
            Console.Write(msg);
            string aStr = Console.ReadLine();

            int a;
            try
            {
                a = Convert.ToInt32(aStr);

            }
            catch
            {
                PrintError("yeniden daxil edin");
                goto l1;
            }
            return a;

        }

        public static void Print(string msg)
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine(msg);
            Console.ForegroundColor = ConsoleColor.White;
        }
        public static void PrintError(string msg)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(msg);
            Console.ForegroundColor = ConsoleColor.White;
        }
    }


}

