﻿// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
//6, 1, 33 -> [6, 1, 33]

void Array()
{
    int []arr = new int[8];
    for(int i = 0; i < arr.Length;i++)
    {
        arr[i] = new Random().Next(0, 50);
    }
    Console.WriteLine("[" + (string.Join(", ", arr)) + "]");
}

Array();