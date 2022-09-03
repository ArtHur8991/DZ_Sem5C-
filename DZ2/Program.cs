﻿//Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0


Console.WriteLine("Размер массива:");
int size = Convert.ToInt32(Console.ReadLine());
int [] array = new int [size];
for(int i = 0; i < array.Length; i++)
{
    array [i] = new Random().Next(-9, 10);
}
int sum = 0;
for(int i = 1; i < array.Length; i = i + 2)
{
    sum+= array [i];
}
Console.WriteLine(string.Join("|", array));
Console.WriteLine(" Сумма чисел на нечётных позициях - " + sum);
