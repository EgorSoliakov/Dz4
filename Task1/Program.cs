// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16


int Prompt()
{
Console.Write("Введите число: ");
int limit = int.Parse(Console.ReadLine());
return limit;
}