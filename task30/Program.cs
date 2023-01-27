// Задача “со звездочкой”: Напишите функцию, которая
// принимает одно число - высоту елочки и рисует ее в
// консоли звездочками.
void elka(int a)
{
    int zvezda = a;
    int min = a;
    int max = a;
        
    for (int j=0;j<a;j++){    
        for (int i=0;i<a*2;i++)
        {
            if ((min <= i) && (i <= max))
            {
                Console.Write("*");
            }
            else
            {
                Console.Write(" ");
            }
            if(i==a*2-1)
            {
                Console.WriteLine("");
            }
        }
    min=min-1;
    max=max+1;
        
    }
}
elka(5);