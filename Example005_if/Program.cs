// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите имя пользователя");
String username = Console.ReadLine();

if (username.ToLower () == "маша")
{ 
    Console.WriteLine ("Ура, этоже Маша!");
}
else
{
    Console.WriteLine ("Привет, ");
    Console.WriteLine (username);
}
