// Напишите программу, которая принимает на вход целое число из отрезка [10, 99] и показывает наибольшую цифру числа.

int num = new Random().Next(10,99);
Console.WriteLine(num);

int num_1 = num % 10;
int num_2 = num/ 10;

// Console.WriteLine(num_2);
// Console.WriteLine(num_1);

if (num_2>num_1)
{
  Console.WriteLine($"наибольшее число:{num_2}");  
}
else if (num_2<num_1)
{
    Console.WriteLine($"наибольшее число:{num_1}");
}
else if (num_2==num_1)
{
    Console.WriteLine($"наибольшего числа нет");
}