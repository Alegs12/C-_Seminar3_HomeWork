// Задача 23 Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125




void Cubes(int N)
{
    System.Console.Write($"1");
    for (int i = 2; i <= N; i++)
    {
        System.Console.Write($", {Math.Pow(i, 3)}");
    }
}

Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
Cubes(num);