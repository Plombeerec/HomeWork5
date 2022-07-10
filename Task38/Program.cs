// Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным элементов массива.

double []Arrayt38(int size,int min, int max)
{
    double[] array = new double[size];

    for(int i = 0; i < size; i++)
    {
        array[i] = (new Random().Next(min, max+1)) + (new Random().NextDouble());
    }
    return array;
}

void ShowArray(double[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

double FindMin(double[] array)
{
    double min = 0;
    double max = 0;
    double result = 0;
    for(int i = 1; i < array.Length; i++)
    {
        min = array[0];
        max = array[0];

        if(min > array[i])
        {
            min = array[i];
        }
        
        
        else if(max < array[i])
        {
            max = array[i];
        }

        result = max - min;
    }
    return result;
}


Console.WriteLine("Введите размер массива");
int Size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимальное значение");
int Min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальное значение");
int Max = Convert.ToInt32(Console.ReadLine());

double[] MyBestArray = Arrayt38(Size, Min, Max);
ShowArray(MyBestArray);
Console.WriteLine("Result is " + FindMin(MyBestArray));