// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Write("Введите натуральное число для M: ");
int m = int.Parse(Console.ReadLine()!);
Console.Write("Введите натуральное число для N: ");
int n = int.Parse(Console.ReadLine()!);
int temp = m;

if (m > n)
{
  m = n;
  n = temp;
}

findSum(m, n, temp = 0);

void findSum(int m, int n, int summ)
{
  if (m > n)
  {
    m = n;
    n = temp;
  }
  summ = summ + n;
  if (n <= m)
  {
    Console.Write($"Сумма элементов = {summ} ");
    return;
  }
  findSum(m, n - 1, summ);
}
