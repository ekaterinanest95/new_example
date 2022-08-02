// See https://aka.ms/new-console-template for more information
Console.Write("Введите Ваше имя: ");
string username = Console.ReadLine()!;
if (username.ToLower() == "маша")
{
    Console.WriteLine("Я так ждала тебя, Маша");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}
