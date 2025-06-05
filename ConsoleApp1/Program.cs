using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        enum Months {Январь, Февраль, Март, Апрель, Май, Июнь, Июль, Август, Сентябрь, Октябрь, Ноябрь, Декабрь}
        static void Main(string[] args)
        {
            foreach (int i in Enum.GetValues(typeof(Months)))
            {
                Console.WriteLine($"{i}  {Enum.GetName(typeof(Months), i)}");
            }

        }
    }
}
