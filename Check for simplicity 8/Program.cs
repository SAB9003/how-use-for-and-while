// See https://aka.ms/new-console-template for more information
Console.WriteLine("Input number:");
bool number_is_prime = true;
int number = int.Parse(Console.ReadLine());
for (int i = 2; i <= Math.Sqrt(number); i++)
{
    if (number % i == 0)
    {
        number_is_prime = false;
        break;
    }
}
if (number_is_prime)
{
    Console.Write("This number is prime");
}
else
{
    Console.WriteLine("This number isn't prime");
}
