// See https://aka.ms/new-console-template for more information
Console.WriteLine("Input number: ");
int number = int.Parse(Console.ReadLine());
bool number_is_prime = true;
Console.WriteLine($"All prime numbers in range from 1 to {number}");
for (int i = 2; i <= number; i++)
{
    for (int j = 2; j <= Math.Sqrt(i); j++)
    {
        if (i % j == 0)
        {
            number_is_prime = false;
            break;
        }
    }
    if (number_is_prime)
    {
        Console.Write($"{i} ");
    }
    number_is_prime = true;
}