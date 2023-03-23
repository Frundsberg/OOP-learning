using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lr5
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                // Зчитуємо послідовність символів з консолі
                Console.Write("Введіть послідовність символів з зайвими пропусками: ");
                string input = Console.ReadLine();
                // Замінюємо пропуски спочатку розбиваючи введену послідовність
                // з пробілом у якості роздільника а потім об'єднуємо заново
                string output = string.Join(" ", input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries));
                // Виводимо результат на консоль
                Console.WriteLine(output);
                Console.ReadLine();
            }
        }
         


    }
}

