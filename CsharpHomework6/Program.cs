/*
Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2

1, -7, 567, 89, 223-> 4
*/
/*
Console.WriteLine("Введите M чисел: "); 
int num = int.Parse(Console.ReadLine());
int[] array = GetArray(num, -500, 1000);
Console.WriteLine(String.Join(", ", array));

int count = 0;
for (int i = 0; i < array.Length; i++){
    if (array[i]>0){
        count++;
    }
}
Console.WriteLine($"Кол-во чисел больше 0 - {count}");

int[] GetArray (int size, int minValue, int maxValue){
    int[] res = new int[size];
    for (int i = 0; i < size; i++){
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
        return res;
 }
*/
/*
Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/
/*
Console.WriteLine("Введите b1: ");
double b1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите k1: ");
double k1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите b2: ");
double b2 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите k2: ");
double k2 = int.Parse(Console.ReadLine());

double x = (b2 - b1) / (k1 - k2);
double y = k2 * x + b2;

Console.WriteLine($"Точки пересечения двух прямых - X = {x}, Y = {y}");
*/