//**Задача 4:** Напишите программу, которая принимает на вход три числа и выдаёт
//максимальное из этих чисел.
//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22
using static System.Console;
Clear();
Write("Введите число a: ");

int num1=Convert.ToInt32(ReadLine());
Write("Введите число b: ");
int num2=int.Parse(Console.ReadLine()!);
Write("Введите число c: ");
int num3=int.Parse(Console.ReadLine()!);

if (num1>num2 && num1>num3) {   Write($"Max = a ({num1})");}
if (num2>num1 && num2>num3) {   Write($"Max = b ({num2})");}
if (num3>num1 && num3>num2) {   Write($"Max = c ({num3})");}