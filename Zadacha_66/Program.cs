//Задача 66: Задайте значения M и N. Напишите программу, которая найдёт 
//сумму натуральных элементов в промежутке от M до N.

Console.Write("Введите число M: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.Write($"Сумма натуральных чисел в интервале от М до N: {SumMN(m - 1, n)}");

int SumMN(int m, int n)
{
    int res = m;
    if (m == n) return 0;
    else if(m > n) return 0;
    else
    {
        m++;
        res = m + SumMN(m, n);
        return res;
    }
}