﻿int Prompt(string message)
{
    System.Console.Write(message);
    return int.Parse(Console.ReadLine());
}

// Вычисление суммы цифр числа
//int CalcSumDigits(int number)
//{
  //  int sum = 0;
    //while (number > 0)
    //{
      //  sum += number % 10;
        //number = number / 10;
    //}
    //return sum;
//}

//int number = Prompt("Введите число > ");
//int result = CalcSumDigits(number);
//System.Console.WriteLine($"Сумма цифр равна {result}");
int Promt(string message)
{
    System.Console.WriteLine(message);
    return int.Parse(Console.ReadLine());
}
int number = Prompt("Введите число > ");
             int s = 0;
            while (number > 0)
            {
 
                s += number % 10;
                number = number /10 ;
 
            }
 Console.WriteLine(s);