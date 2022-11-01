// Задача 19 Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да


void Palindrom5(int num)
{
    //int num = Convert.ToInt32(Console.ReadLine());
    if (num > 9999 && num < 100000) 
        {
            int num5 = num % 10;
            int num4 = num/10 % 10;
            // int num3 = num/100 % 10;
            int num2 = num/1000 % 10;
            int num1 = num/10000 % 10;
            
            if (num5 == num1 && num4 == num2) System.Console.WriteLine($"Число {num} -> палиндром");
            else System.Console.WriteLine($"Число {num} ->  не палиндром");
        }
    else System.Console.WriteLine("Нужно ввести пятизначное число");
}

System.Console.WriteLine("Введите пятизначное число");
int num = Convert.ToInt32(Console.ReadLine());
Palindrom5(num);
