// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12
Console.Write("Введите число: ");
int a = int.Parse(Console.ReadLine());
int len = Length(a);
int Length(int a)
{
    int index = 0;
    while (a > 0)
    {
        a /= 10;
        index++;
        }
    return index;
}
int Sum(int a, int len)
{
    int sum = 0;
    for (int i = len; i >= 1; i--)
    {
        sum += a % 10;
        a /= 10;
        }
return sum;
}
Console.Write($"Сумма цифр в числе {a} равно: {Sum(a,len)}");