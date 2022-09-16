//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт,
//какое число большее, а какое меньшее. a = 5 b = 7->max = 7,
//a = 2 b = 10 -> max = 10, a = -9 b = -3 -> max = -3

using static System.Console;
Clear();
Write("Введите число a: ");
int num1=Convert.ToInt32(ReadLine());
Write("Введите число b: ");
int num2=int.Parse(Console.ReadLine()!);

if(num1>num2)
{    Write($"Max = a ({num1})  ");
     Write($"Min = b ({num2})");}

if(num1<num2)
{    Write($"Max = b ({num2})  ");
     Write($"Min = a ({num1})");}