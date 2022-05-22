// 3. Напишите программу, которая 
// задаёт массив из 8 элементов случайными числами и 
// выводит их на экран. Оформите заполнение массива и вывод в виде функции (пригодится в следующих задачах)

int[] RandomArray(int length, int maxValue)
{
    int[] array = new int[length];
    for (int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(1, maxValue + 1);
    }
    return array;
}

void PrintArray(int[] array)
{
    int length = array.Length;
    for (int i = 0; i < length; i++)
    {
        Console.Write($"{array[i]}, ");
    }
}

PrintArray(RandomArray(8, 100));