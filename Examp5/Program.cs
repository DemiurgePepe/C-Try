Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "макс")
{
    Console.WriteLine("Это же МАКС!");
}
else
{
    Console.Write("Привет, ");
    Console.Write(username);
}