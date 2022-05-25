/*
Задача 29: Напишите программу, которая задаёт массив
из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
*/

Console.WriteLine("Напиши из скольки цифр ты хочешь получить массив: ");
int SizeArray = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Какая минимальная цифра массива?");
int MinNumberArray = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Какая максимальная цифра массива?");
int MaxNumberArray = Convert.ToInt32(Console.ReadLine());
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
        if (i < array.Length - 1)
        {
            Console.Write(", ");
        }
    }

}
int[] array = new int[SizeArray];
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(MinNumberArray, MaxNumberArray);
}

PrintArray(array);
Console.Write(" -> [");
PrintArray(array);
Console.Write("]");
