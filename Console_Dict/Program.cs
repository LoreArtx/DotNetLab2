using Console_Dict;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Console_Dict.Dict;

namespace Dictionary_Console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = UTF8Encoding.UTF8;
            ExtendedDictionary<int, string, string> dict = new ExtendedDictionary<int, string, string>();
            // Створення списку

            int count = 1;
            int choice;
            do
            {
                Console.WriteLine("\nВведіть перше значення елементу :");
                string var1 = Console.ReadLine();
                Console.WriteLine("Введіть друге значення елементу :");
                string var2 = Console.ReadLine();
                dict.Add(count, var1, var2);
                // Додавання елементів у список

                count++;

                Console.WriteLine("Якщо бажаєте зупинитись, введіть 0");
                while(!Int32.TryParse(Console.ReadLine(),out choice))
                {
                    Console.WriteLine("Невірно введено значення! Спробуйте ще раз!");
                }

            } while (choice != 0);
            // Надавання елементів для опрацювання

            Console.WriteLine("\n\nЯкий елемент списку ви бажаєте знайти?");
            Console.WriteLine("Введіть перше значення елементу :");
            string fnd_var1 = Console.ReadLine();
            Console.WriteLine("Введіть друге значення елементу :");
            string fnd_var2 = Console.ReadLine();

            PrintTable(dict, fnd_var1,fnd_var2);
        }

        public static void PrintTable(ExtendedDictionary<int, string, string> dict,string find_var1,string find_var2)
        {
            Console.WriteLine("\n\n\nЕлементи списку:");
            dict.Print();
            Console.WriteLine("-------------------------");
            dict.Remove(1);
            // Видаляємо елемент списку

            Console.WriteLine("Список елементів після видалення першого по індексу об'єкта:");
            dict.Print();
            Console.WriteLine("-------------------------");
            dict.ExistKey(2);
            dict.ExistKey(4);
            // Перевірки на існування ключа 1 та 4 відповідно

            Console.WriteLine("--------------------------");
            Console.WriteLine($"Кількість елементів:{dict.Count()}");
            // Кількість елеметів списку
            
            Console.WriteLine("--------------------------");
            dict.ExistValues(find_var1, find_var2);
            // Пошук ключа зі значеннями

            Console.WriteLine("--------------------------");
            Console.WriteLine($"dict[2] ={dict[2].value1}-{dict[2].value2}");
            // Робота з елементом списку по індексу

            Console.WriteLine("--------------------------");
            foreach (var i in dict)
            {
                Console.WriteLine($"Key:{i.key}--{i.value1}--{i.value2}");
            }
            // Проходження по списку циклом foreach
        }
    }
}
