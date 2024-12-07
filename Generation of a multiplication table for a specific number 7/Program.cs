// See https://aka.ms/new-console-template for more information
Console.WriteLine("Input the number by which we will multiply:");
int number = int.Parse(Console.ReadLine());
Console.WriteLine("Your multiplication table:");
for (int i = 1; i <= 10; i++)
{
    Console.WriteLine($"{number} * {i} = {number*i}");
}
