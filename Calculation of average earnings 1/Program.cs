// See https://aka.ms/new-console-template for more information
int number_of_workers, amount_of_workers_salary = 0;
Console.WriteLine("Input the number of workers:");
number_of_workers = int.Parse(Console.ReadLine());
for (int i = 0; i < number_of_workers; i++)
{
    Console.WriteLine($"Input the salary of the {i + 1} worker:");
    amount_of_workers_salary += int.Parse(Console.ReadLine());
}

Console.WriteLine($"Average salary {(double)amount_of_workers_salary / number_of_workers}");