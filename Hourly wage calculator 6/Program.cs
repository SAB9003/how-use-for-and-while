// See https://aka.ms/new-console-template for more information
Console.WriteLine("Input how many hours did the worker work:");
int hour = int.Parse(Console.ReadLine());
if (hour <0 || hour > 24)
{
    Console.WriteLine("Error: how many working hours a day cannot be");
    return;
}
int wage_for_hour, salary_per_day = 0;


//Якщо за кожну годину отримує одну суму 
//Console.WriteLine("Input how much does he earn per hour:");
//wage_for_hour = int.Parse(Console.ReadLine());
//salary_per_day = wage_for_hour*hour;


//Якщо за кожну годину отримує різні суми
for (int i = 0; i < hour; i++)
{
    Console.WriteLine($"Input how much does he earn in {i} hours:");
    wage_for_hour = int.Parse(Console.ReadLine());
    salary_per_day += wage_for_hour;
}


Console.WriteLine($"The worker earned {salary_per_day} for that day");