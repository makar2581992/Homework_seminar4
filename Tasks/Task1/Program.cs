// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.WriteLine("Введите число А: ");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число B: ");
int b = int.Parse(Console.ReadLine());

int number = a;
int degree = b;
int result = number;
int count = 1;

while (count < degree)
{
    result = result * number;
    count++;
}

System.Console.WriteLine($" Число {number} в {degree}-й степени равно {result}");