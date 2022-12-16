using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Sorted_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = UTF8Encoding.UTF8;
            string str = "Без діла слабіє сила";
            Console.WriteLine($"Текст: {str}");
            Console.WriteLine("Кількість літер у слові:");
            Console.WriteLine(str.Count_Symbols('с'));
            Console.WriteLine("Текст задом наперед:");
            Console.WriteLine(str.Reverse());
            // Опрацювання рядка

            int[] numbers = new int[] { 2, 0, 0, 4, 1, 2, 0, 4 };
            Console.WriteLine("\nСписок чисел: [{0}]", string.Join(", ", numbers));
            int sub_number = 0;
            Console.WriteLine($"Кількість {sub_number} в масиві:{numbers.Count<int>(sub_number)}");
            // Опрацювання масиву чисел

            string[] words = new string[] { "Zhytomyr", "Socks", "Ice-cream", "Victory" };
            Console.WriteLine("\nСписок слів: [{0}]", string.Join(", ", words));
            string sub_word = "Zhytomyr";
            Console.WriteLine($"Кількість слів {sub_word}:{words.Count<string>(sub_word)}");
            // Опрацювання масиву строк

            char[] symbols = new char[] { 'l', 'o', 'r', 'e', 'a', 'r', 't', 'x', 'd' };
            Console.WriteLine("\nСписок символів: [{0}]", string.Join(", ", symbols));
            char sub_symbol = 'r';
            Console.WriteLine($"Кількість символів {sub_symbol}:{symbols.Count<char>(sub_symbol)}");
            // Опрацювання масиву символів

            double[] array_not_special = new double[] { 5, 9, 4, 1, 8, 5, 2, 4 };
            Console.WriteLine("\nСписок чисел: [{0}]", string.Join(", ", array_not_special));
            Console.Write($"Перетворюємо масив на унікальний без повторень : ");
            double[] arr_special = array_not_special.Special<double>();
            foreach (double i in arr_special) 
            {
                Console.Write($" {i} ");
            }
            // Перетворення на унікальний масив без повторень
        }
    }
}
