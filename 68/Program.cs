/* Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29 */

Console.Write("Введите значение числа m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение числа n: ");
int n = Convert.ToInt32(Console.ReadLine());
int AckermannFunction(int m, int n)
{
    int res = 0;
    if (m == 0)
    {
        res = n+1;
        return res;
    }
    else if (m > 0 && n == 0)
    {
        res = AckermannFunction(m -1, 1);
        return res;
    }
    else if (m > 0 && n > 0)
    {
        res = AckermannFunction(m - 1, AckermannFunction(m, n - 1));
        return res;
    }
    return res;
}
int result = AckermannFunction(m,n);
Console.WriteLine(result);