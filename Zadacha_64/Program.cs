//Задача 64: Задайте значения M и N. Напишите программу, которая выведет 
//все натуральные числа в промежутке от M до N.

Console.Write("Введите число M: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());;
NaturalToLow(m, n);


void NaturalToLow(int m, int n)
{
    if (n > m)
    {
        return;
    }
    else
    {
        NaturalToLow(m, n + 1);
        Console.Write(n + " ");
    }
}