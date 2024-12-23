﻿
using System;

class FifthTask
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите элементы массива через пробел:");
        string input = Console.ReadLine();

        int[] array = Array.ConvertAll(input.Split(' '), int.Parse);
        Console.WriteLine("Буль-буль, пузырьки");

        BubbleSort(array);

        string result = string.Join(", ", array);
        Console.WriteLine("Отсортированный массив: " + result);
    }

    static void BubbleSort(int[] arr)
    {
        int n = arr.Length;

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n - i - 1; j++)
            {
                if (arr[j] > arr[j + 1])
                {
                    int temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;
                }
            }
            PrintArray(arr);
        }
    }

    static void PrintArray(int[] arr)
    {
        string result = string.Join(", ", arr);
        Console.WriteLine("Промежуточный массив: " + result);
    }
}
