using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число 1: ");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите число 2: ");
            double num2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите операцию\n1. Сложение\n2. Деление\n3. Умножение \n4. Деление");
            int i = Convert.ToInt32(Console.ReadLine());
            if (i == 1)
            {
                Console.WriteLine("Результат сложения: " + (num1 + num2));
            }
            if (i == 2)
            {
                if (num2 != 0)
                {
                    Console.WriteLine("Результат деления: " + (num1 / num2));
                }
                else
                {
                    Console.WriteLine("Ошибка: Деление на ноль невозможно.");
                }
            }
            if (i == 3)
            {
                Console.WriteLine("Результат умножения: " + (num1 * num2));
            }
            if (i == 4)
            {
                if (num2 != 0)
                {
                    Console.WriteLine("Результат деления: " + (num1 / num2));
                }
                else
                {
                    Console.WriteLine("Ошибка: Деление на ноль невозможно.");
                }
            }
        }
    }
}
