using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _3._7_ConsoleQuestionnaire
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Получаем имя
            Console.Write("Enter your name: ");
            string name = "";
            for (int i = 0; i < 50; i++) // Даем пользователю 50 попыток корректно ввести имя, должно хватить)
            {
                string tempName = Console.ReadLine();
                if (tempName.Any(s => !char.IsLetter(s)) || tempName == "") // Проверяем является ли любой символ не буквенным
                {
                    Console.Write("Please, again enter your name correctly: ");
                }
                else
                {
                    name = tempName;
                    break;
                }
            }
            // Получаем возраст
            Console.Write("Enter your age: ");
            byte age = 0;
            for (int i = 0; i < 50; i++) // Даем пользователю 50 попыток корректно ввести возраст, должно хватить)
            {
                if (byte.TryParse(Console.ReadLine(), out age)) // Проверяем успешна ли попытка преобразования строки в тип byte и выводим в переменную в случае успеха
                {
                    if (age != 0 && age < 130) break;
                    else Console.Write("Please, again enter your age correctly: ");
                }
                else Console.Write("Please, again enter your integer age correctly: ");
            }
            // Получаем дату рождения
            Console.Write("Enter your birthdate in formar **.**.****: ");
            string birthDate = "";
            for (int i = 0; i < 50; i++) // Даем пользователю 50 попыток корректно ввести , должно хватить)
            {
                string tempBirthDate = Console.ReadLine();
                if (tempBirthDate.Any(s=>char.IsLetter(s)) || tempBirthDate.Length > 10 || tempBirthDate.Length == 0 || tempBirthDate.Count(ch=>ch == '.') != 2)
                {
                    Console.Write("Please, again enter your birthdate correctly: ");
                }
                else
                {
                    birthDate = tempBirthDate;
                    break;
                }
            }
            // Выводим полученные имя и возраст, дату рождения
            Console.WriteLine($"Your name is {name}, age is {age}, birthdate is {birthDate}");
            
            Console.ReadKey();
        }
    }
}
