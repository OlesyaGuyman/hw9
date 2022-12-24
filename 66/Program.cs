/* Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30 */

Console.Write("Введите значение для числа М: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение для числа N: ");
int n = Convert.ToInt32(Console.ReadLine());

int SumElement(int m1, int n1)
{
    int result = 0;
    if (n1 == m1)
    {
        return result + m1;
    }
    if (m1 > n1)
    {
        result += SumElement(m1 - 1, n1);
    }
    else
    {
        result += SumElement(m1 + 1, n1);
    }
    return result += m1;
}

int res = SumElement(m, n);
Console.WriteLine(res);
