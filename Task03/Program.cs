// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125
Console.Clear();
int NewNumber(string str)
{
    Console.Write(str);
    int number = int.Parse(Console.ReadLine());
    return number;
}
void CubeTable(int N)
{
    int index = 1;
    while (index <= N)
    {
        double cube = Math.Pow(index, 3);
        Console.Write($" {cube}");
        index++;
    }
}
int number = NewNumber($"Таблица кубов чисел от 1 до ");
CubeTable(number);