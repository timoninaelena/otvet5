﻿// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int [] array = GitArray(4);
Console.Write($"[{String.Join(",", array)}]");
int[] GitArray(int size)

{
    int[] result = new int[size];
    for (int i=0; i< result.Length; i++)
    {
        result[i] = new Random().Next(100,1000);
    }
    return result;
}
int count = 0;

for (int i = 0; i < array.Length; i++)
    if ((array[i] % 2) == 0)
   count++;

Console.WriteLine ($" количество четных чисел: {count}");
