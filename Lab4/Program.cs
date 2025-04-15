namespace Lab4;

class Program
{
    static void Main(string[] args)
    {
        for (int i = 1; i <= 10; i++)
{
    Console.WriteLine(i);
}
Console.WriteLine();
for (int i = 1; i <= 20; i++)
{
    if (i % 2 == 0)
    {
        Console.WriteLine(i);
    }
}
int number;
do
{
    Console.Write("Enter a number greater than 100: ");
    number = Convert.ToInt32(Console.ReadLine());
} while (number <= 100);
int I = 10;
while (I <= 1000)
{
    Console.WriteLine(I);
    I+= 10;
}
for (int i = 1; i <= 10; i++)
{for (int i = 1; i <= 10; i++)
{
    for (int j = 1; j <= i; j++)
    {
        Console.Write("*");
    }
    Console.WriteLine();
}

    for (int j = 1; j <= i; j++)
    {
        Console.Write("*");
    }
    Console.WriteLine();
}


}}
