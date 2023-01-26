//Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int summa_cifr(int a)
{
    int ost;
    int result=0;
    for (int i =0; a>0;i++)
    {
        ost=a%10;
        a=a/10;
        result=result+ost;
    }
    return result;
}
Console.WriteLine("Введите число:");
int chislo = int.Parse(Console.ReadLine()!);
int sum = summa_cifr(chislo);
Console.WriteLine($"{chislo} -> {sum}");
