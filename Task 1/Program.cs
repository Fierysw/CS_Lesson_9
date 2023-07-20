// Задача 64: Задайте значение N. Напишите программу, которая выведет все 
// натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.Write("Введите натуральное число для N: ");
int n = int.Parse(Console.ReadLine()!);
int count = 2;
printNumber(n, count);
Console.Write(1);

void printNumber(int n, int count)
{
  if (count > n) return;
  printNumber(n, count + 1);
  Console.Write(count + ", ");
}