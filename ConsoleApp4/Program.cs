using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    enum UserRole { Администратор, Модератор, Пользователь, Гость }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите роль пользователя (Администратор, Модератор, Пользователь, Гость):");
            string input = Console.ReadLine();
            UserRole role;
            try
            {
                role = (UserRole)Enum.Parse(typeof(UserRole), input, true);
                Console.WriteLine($"Вы зарегестрировались как: {role}");
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Ошибка: введена некорректная роль пользователя.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Произошла ошибка: {ex.Message}");
            }
        }
    }
}
