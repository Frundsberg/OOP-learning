using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lr4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введіть кількість елементів масиву: ");
            int n = int.Parse(Console.ReadLine());
            // створюємо масив і заповнюємо його значеннями, які вводить користувач
            double[] arr = new double[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Введіть {i + 1}-й елемент масиву: ");
                arr[i] = double.Parse(Console.ReadLine());
            }
            // знаходимо суму від'ємних елементів масиву
            double negativeSum = 0;
            foreach (double elem in arr)
            {
                if (elem < 0)
                {
                    negativeSum += elem;
                }
            }
            Console.WriteLine($"Сума від'ємних елементів масиву: {negativeSum}");
            Console.ReadLine();
            // знаходимо індекс максимального та мінімального елементів масиву
            int max = 0, min = 0;
            for (int i = 0; i < n; i++)
            {
                if (arr[i] > arr[max])
                {
                    max = i;
                }
                if (arr[i] < arr[min])
                {
                    min = i;
                }
            }
            // знаходимо добуток елементів масиву, розташованих між максимальним і мінімальним елементом
            double product = 1;
            int startIndex = Math.Min(max, min) + 1;
            int endIndex = Math.Max(max, min) - 1;
            for (int i = startIndex; i <= endIndex; i++)
            {
                product *= arr[i];
            }
            Console.WriteLine($"Добуток елементів масиву, розташованих між максимальним і мінімальним елементом: {product}");
            Console.ReadLine();

            // сортуємо масив за зростанням
            Array.Sort(arr);
            // виводимо відсортований масив
            Console.WriteLine("Відсортований масив:");
            foreach (double elem in arr)
            {
                Console.Write(elem + " ");
                Console.ReadLine();
            }
            int[,] array = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            // створюємо двовимірний массив
            Console.WriteLine("Двовимірний масив:");
            for (int i = 0; i < array.GetLength(0); i++)
            {
                // в циклі перебираємо і поелементно виводимо массив
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write("{0} ", array[i, j]);
                }
                Console.WriteLine();
            }
            // виводимо результати
            Console.WriteLine("Елемент, розташований у правому верхньому куті: {0}", array[0, array.GetLength(1) - 1]);
            Console.ReadLine();
            Console.WriteLine("Елемент, розташований у лівому нижньому куті: {0}", array[array.GetLength(0) - 1, 0]);
            Console.ReadLine();
        }

}    }
