/*
Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/

Console.WriteLine("Напиши число и программа выдаст сумму всех цифр в вашем числе");
int number = Convert.ToInt32(Console.ReadLine());
int NumberSum = 0;
int temp = number;
int result = 0;

while (temp > 0)
{
    NumberSum = temp % 10;
    temp = temp / 10;
    result = result + NumberSum;
}
Console.WriteLine($"{number} -> {result}");