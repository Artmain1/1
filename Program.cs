﻿Console.Write("Введите имя пользователя:");
string? username = Console.ReadLine();

if (username?.ToLower() == "Маша")
{
    Console.WriteLine("Ура это же маша");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}