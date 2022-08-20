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
Write($"{String.Join(",", array)}");
WriteLine("]");
WriteLine("Введите число");
int a = int.Parse(ReadLine());
foreach (int b in array)
{
    if (b == a)
    {
        WriteLine($"Число {a} присутствует в массиве");
        break;
    }
}
WriteLine("Запрошенное число отсутствует в массиве");



// Задать массив
void FillArr(int[] arr, int minValue, int maxValue)
{
    for (int i=0; i<arr.Length; i++)
    {
        arr [i] = new Random().Next(minValue, maxValue+1);
    }
}