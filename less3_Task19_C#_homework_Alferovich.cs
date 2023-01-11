// Задача 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Пожалуйста, введите пятизначное число: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num > 99999 || num < 10000)
Console.WriteLine("Ошибка: введено не пятизначное число.");
else
{
int [] array = new int[5];

for (int index = 0; index < 5; index++)
{
    array[index] = num % 10;
    Console.Write($"{array[index]} ");
    num = num / 10;

    Console.WriteLine("");
}
Console.Write($"{array[0]}");
Console.Write($"{array[1]}");
Console.Write($"{array[2]}");
Console.Write($"{array[3]}");
Console.Write($"{array[4]}");

if (array[0] == array[4] && array[1] == array[3])
Console.WriteLine(", число - палиндром.");
else Console.WriteLine(", число - не палиндром.");
}