using System;

namespace ConsoleApp.Demo
{
    internal class Program
    {
        static void Main(string[] args)


        {
            string wSpace = new string(' ', Console.WindowWidth);

            Console.WriteLine("demo");
            Console.WriteLine("The end");
            
            Console.WriteLine("ata");
            Console.ReadKey();

            Console.CursorTop--;
            Console.WriteLine(wSpace);
            Console.ReadKey();








            return;
            Console.WriteLine("eded daxil edin");
            

            bool suc = int.TryParse(Console.ReadLine(), out int a);

            switch (a)
                {
                    case 1:
                        Console.WriteLine("I gun");
                        break;

                    case 2:
                        Console.WriteLine("II gun");
                        break;
                    case 3:
                        Console.WriteLine("III gun");
                        break;
                    case 4:
                        Console.WriteLine("IV gun");
                        break;
                    case 5:
                        Console.WriteLine("V gun");
                        break;
                    case 6:
                        Console.WriteLine("VI gun");
                        break;
                    case 7:
                        Console.WriteLine("VII gun");
                        break;


                    default:

                        Console.WriteLine("duzgun deyil");

                        break;

                    
            }

          










        }
    }
}
