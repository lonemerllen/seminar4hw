// Задача 25: Напишите функцию, которая принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// Нельзя использовать библиотеку Math!
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int stepen(int c, int n)
{
    int sum=1;
    for (int i=0;i<n;i++)
    {
        sum=sum*c;
    }
    return sum;
}
Console.WriteLine("Введите число:");
int chislo = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите степень:");
int step = int.Parse(Console.ReadLine()!);
int result = stepen(chislo,step);
Console.WriteLine($"{chislo}, {step} -> {result}");