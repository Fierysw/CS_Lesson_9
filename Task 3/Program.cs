// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.Write("Введите натуральное число для M: ");
int m = int.Parse(Console.ReadLine()!);
Console.Write("Введите натуральное число для N: ");
int n = int.Parse(Console.ReadLine()!);

int functionAkkerman = findFunctionAkkerman(m, n);

Console.Write($"Функция Аккермана = {functionAkkerman} ");

int findFunctionAkkerman(int m, int n)
{
  if (m == 0) return n + 1;
  else if (n == 0) return findFunctionAkkerman(m - 1, 1);
  else return findFunctionAkkerman(m - 1, findFunctionAkkerman(m, n - 1));
}