using ClassLibrary.Helpers;
using System;
namespace Homework.Phone
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            Console.Title = "Phone System";

            
        l1:
            int len = Manitor.IntEdedOxu("Nece telefon olsun?:");
            if (len <= 0)
            {
                goto l1;
            }
               Phone[] phones = new Phone[len];
            for (int i = 0; i < phones.Length; i++)
            {
                Phone phone = new Phone();
                phone.producer = Manitor.ReadString($"{i + 1}.Telefonun istehsalcisi:");
                phone.OperatingSystem = Manitor.ReadString($"{i + 1}.Telefonun emeliyyat sistemi:");
                phone.color = Manitor.ReadString($"{i + 1}.Telefonun rengi:");
                phone.memory = Manitor.IntEdedOxu($"{i + 1}.Telefonun yaddasi:");
                phone.MaterialOfbody = Manitor.ReadString($"{i + 1}.Telefonun korpus matreali:");

                phones[i] = phone;
                Console.WriteLine("----------");


            }

            Console.WriteLine("###### List of phone ######");
            foreach (var item in phones)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}
