// 1. Напишите цикл, который принимает на вход два числа (A и B) и 
// возводит число A в натуральную степень B.

double Exponentiation(double a, int b)
{
    double result = 1;
    for (int i = 1; i <= b; i++)
    {
        result *= a;
    }
    return result;
}

Console.WriteLine(Exponentiation(-2.5, 3));
Console.WriteLine(Exponentiation(3, 3));
Console.WriteLine(Exponentiation(10, 6));