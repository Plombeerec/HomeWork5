//Задайте массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.

int[] ArrayAgain(int size, int min, int max)
{
    int[] array = new int[size];

    for(int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(min, max+1);
    }
    return array;
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}


int FindSum(int[] array)
{
    int sum = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(i%2 ==0) sum = sum + array[i];
    }
    return sum;
}

Console.WriteLine("Введите размер массива");
int Size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимальное значение");
int Min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальное значение");
int Max = Convert.ToInt32(Console.ReadLine());

int[] MyBestArray = ArrayAgain(Size, Min, Max);
ShowArray(MyBestArray);
Console.WriteLine(FindSum(MyBestArray));