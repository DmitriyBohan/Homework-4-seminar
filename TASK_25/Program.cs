/*
Задача 25: Напишите цикл, который принимает на 
вход два числа (A и B) и возводит число A в 
натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/

Console.WriteLine("Напиши 2 числа (А и В) и мы возведем число A в натуральную степень B");
Console.WriteLine("Напиши число А: ");
int Anumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Напиши число B: ");
int Bnumber = Convert.ToInt32(Console.ReadLine());
int result = 1;
for (int i = 0; i < Bnumber; i++)
{
    result = result * Anumber;
}
Console.WriteLine($"{Anumber}, {Bnumber} -> {result}");