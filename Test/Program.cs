// **Задача 32:** Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
// **Задача 33:** Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
using static System.Console;
Clear();
Write("Задайте количество элементов массива - ");
int n = int.Parse(ReadLine());
Write("Задайте минимальный элемент массива - ");
int min = int.Parse(ReadLine());
Write("Задайте максимальный элемент массива - ");
int max = int.Parse(ReadLine());
int [] array = new int [n];
FillArr(array, min, max);
Write("[");
PrintArr(array);
WriteLine("]");
for (int i=0; i<array.Length; i++)
{
    array[i] = 0-array[i];
}
Write("[");
PrintArr(array);
WriteLine("]");


// Задать массив
void FillArr(int[] arr, int minValue, int maxValue)
{
    for (int i=0; i<arr.Length; i++)
    {
        arr [i] = new Random().Next(minValue, maxValue+1);
    }
}
// Печать массива
void PrintArr(int [] arr)
{
    for (int i=0; i<arr.Length; i++)
    {
        Write($"{arr [i]}");
        if (i<arr.Length-1) Write (",");
    }
}
