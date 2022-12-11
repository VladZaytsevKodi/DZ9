// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт 
//сумму натуральных элементов в промежутке от M до N.
//M = 1; N = 15 -> 120
//M = 4; N = 8. -> 30

Console.WriteLine("Ввести число M(начало проежутка) ");
int m = int.Parse(Console.ReadLine()!);

Console.WriteLine("Ввести число N(конец проежутка) ");
int n = int.Parse(Console.ReadLine()!);

int SumNumbers(int m, int n)
{
    if (m > n) 
    {
     return n + SumNumbers(m, n + 1);
    }
    if (m < n)
    {
      return n + SumNumbers(m, n - 1);  
    }
    if (m == n)
    {
      return 0;  
    }
    return SumNumbers(m, n);
}
Console.WriteLine($"результат {SumNumbers(m, n)}");