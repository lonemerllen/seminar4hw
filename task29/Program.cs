// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]
void output(int[] a)
{
    int len = a.Length;
    Console.Write("[");
    for (int i =0; i<len;i++)
    {
        if (i!=len-1){
        Console.Write($"{a[i]}, ");
        }
        else{
            Console.Write($"{a[i]}");
        }
    }
    Console.Write("]");
}

int[] array = new int[] {6, 1, 33};
output(array);