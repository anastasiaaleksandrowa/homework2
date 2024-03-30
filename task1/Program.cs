// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.

int num = new Random().Next(0, 10000000);
Console.WriteLine(num);


if (num % 7 == 0 && num % 23 == 0)
{
    Console.WriteLine("да");
}
else
{
    Console.WriteLine("нет");
}
