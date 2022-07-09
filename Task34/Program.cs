// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

int[] NewArray(int size, int min, int max)
{
    int[] array =new int[size];

    for(int i = 0; i< size; i ++)
    {
        array[i] = new Random().Next(min, max);
    }
    return array;
}

void ShowArray(int[] array)
{
    for(int i = 0; i<array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

int SortAndCount(int[] array)
{
    int count = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] % 2 == 0) count++;
    }
    return count;
    
}

Console.WriteLine("Введите размер массива");
int Size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимальное значение");
int Min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальное значение");
int Max = Convert.ToInt32(Console.ReadLine());

int[] MyBestArray = NewArray(Size, Min, Max);
ShowArray(MyBestArray);
Console.WriteLine(SortAndCount(MyBestArray));