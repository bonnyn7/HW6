// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

using System;
namespace Homework6;
class Task1
{
    public static void Main (string[] args)
    {
        Console.Write($"Введите число М (количество чисел): ");
        int m = Convert.ToInt32(Console.ReadLine());
        int[] arrayNumbers = new int[m];

        void InputNumbers(int m)
        {
            for (int i = 0; i < m; i++)
            {
                Console.Write($"Введи {i + 1} число: ");
                arrayNumbers[i] = Convert.ToInt32(Console.ReadLine());
            }
        }

        int Compare (int[] arrayNumbers)
        {
            int count = 0;
            for (int i = 0; i < arrayNumbers.Length; i++)
            {
                if (arrayNumbers[i] > 0) count += 1;
            }
            return count;
        }
        InputNumbers (m);
        Console.WriteLine($"Введено чисел больше 0: {Compare (arrayNumbers)} ");
    }
}