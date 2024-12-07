// See https://aka.ms/new-console-template for more information
int number_of_strars;
Console.WriteLine("Input the number of stars in graphics:");
number_of_strars = int.Parse(Console.ReadLine());
for (int i = 0; i < number_of_strars; i++)
{
    for (int j = 0; j <= i; j++)
    {
        Console.Write("*");
    }
    Console.WriteLine();
}
