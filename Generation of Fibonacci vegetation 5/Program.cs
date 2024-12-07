// See https://aka.ms/new-console-template for more information
int first_number = 0, second_number = 1,temt;
Console.WriteLine("Input number:");
int number = int.Parse(Console.ReadLine());
Console.WriteLine($"{number} fibonacci sequence");
Console.Write($"{first_number}  {second_number}  ");
//Якщо враховувати 0 і 1
for (int i = 2; i < number; i++)
{
    temt = first_number + second_number;
    first_number = second_number;
    second_number = temt;
    Console.Write($"{temt}  ");
}
//Якщо не враховувати 0 і 1
//for (int i = 0; i < number; i++)
//{
//    temt = first_number + second_number;
//    first_number = second_number;
//    second_number = temt;
//    Console.Write($"{temt}  ");
//}