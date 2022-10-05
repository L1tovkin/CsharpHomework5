/*Все массивы от 5-ти элементов
Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2
*/
/*
int[] array = GetArray(5, 100, 1000);
Console.WriteLine(String.Join(" ", array));
int evenNum = 0;
for (int i = 0; i < array.Length; i++){
    if (array[i] % 2 == 0)
    {
        evenNum++;
    }
}
Console.WriteLine($"Кол-во четных чисел - {evenNum}");

int[] GetArray(int size, int minValue, int maxValue){
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(minValue, maxValue);
    }
    return result;
}
*/
/*
Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19

[-4, -6, 89, 6] -> 0
*/
/*
int[] array = GetArray(5);
Console.WriteLine(String.Join(" ", array));
int sum = 0;
for (int i = 0; i < array.Length; i+=2)
{
   sum = sum + array[i];
} 
Console.WriteLine($"Сумма элементов на нечетных позициях - {sum}");

int[] GetArray(int size)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(1, 100);
    }
    return result;
}
*/
/*
Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76
*/
/*
float[] array = GetArray(5);
Console.WriteLine(String.Join(" ", array));
double maxArr = array[0];
double minArr = array[0];
for (int i = 0; i < array.Length; i++){
    if (array[i] < minArr){
        minArr = array[i];
    }
    else if (array[i] > maxArr){
        maxArr = array[i];
    }
}
Console.WriteLine($"Разница между макс и мин элементами массива - {maxArr - minArr} ");

float[] GetArray(int size){
    float[] result = new float[size];
    for (int i = 0; i < size; i++){
        result[i] = new Random().Next(1, 100);
    }
    return result;
}
*/


