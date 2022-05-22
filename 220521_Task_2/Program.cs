// Напишите программу, которая принимает на вход число и 
// выдаёт сумму цифр в числе.

int SumNum(int num)
{
    int result = 0;
    while (num > 0)
    {
        result += num % 10;
        num /= 10;
    }
    return result;
}

Console.WriteLine(SumNum(12345));