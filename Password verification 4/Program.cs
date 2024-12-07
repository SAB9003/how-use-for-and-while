// See https://aka.ms/new-console-template for more information
Console.WriteLine("Input password: ");
string password = Console.ReadLine();
bool is_number = false, is_letter = false, is_special_character = false, are_8_characters = password.Length >= 8, end = false;
if (are_8_characters)
{
    for (int i = 0; i < password.Length; i++)
    {
        if (char.IsDigit(password[i]))
        {
            is_number = true;
        }
        if (char.IsLetter(password[i]))
        {
            is_letter = true;
        }
        if (Char.IsLetterOrDigit(password[i]))
        {
            is_special_character = true;
        }
        if (is_letter && is_number && is_special_character)
        {
            end = true;
            break;
        }
    }
    if (end)
    {
        Console.WriteLine("The password is correctly");
    }
    else
    {
        Console.WriteLine("The password was incorrectly");
    }
}
else
{

}
{
    Console.WriteLine("The password was incorrectly");
}