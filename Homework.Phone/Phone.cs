using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework.Phone
{
    internal class Phone
    {
        public int id;
        public string producer;        
        public string OperatingSystem;
        public string color;
        public int memory;
        public string MaterialOfbody;
       

        static int counter = 0;
        public Phone()
        {
            counter++;
            id = counter;
        }
        public override string ToString()
        {
            return $"No:{id}\n" +
                $"Name: {producer}\n" +
                $"Surname: {OperatingSystem}\n" +
                $"DataTime: {color}\n" +
                $"Group name: {memory}\n" +
                $"Spacialty: {MaterialOfbody}\n";

        }
    }
}

