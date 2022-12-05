// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да
Console.Clear();
int ReversNum(int num)
{
    int rev = 0;
    while (rev < 100000)
    {
        rev = (rev + (num % 10))*10;
        num = num / 10;
    }
    rev = rev / 10; 
    return rev;
}
void CheckPalindrome(int num, int rev)
{
    if (num > 99999 || num < 10000)
    {
        Console.WriteLine("Неверное значение");
    }
    else
    {
        if (num == rev)
        {
            Console.WriteLine($"{num} -> да");
        }
        else
        {
            Console.WriteLine($"{num} -> нет");
        }
    }
}

Console.Write("Введите пятизначное число ");
int number = int.Parse(Console.ReadLine());
int revers = ReversNum(number);
CheckPalindrome(number, revers);

