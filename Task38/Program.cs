/*Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76*/


double[] array = new double[5];
ArrayRandom(array);
double result =  DifferenceMaxMin(array);
ArrayPrintConsole(array, result);





void ArrayPrintConsole(double[] array, double difference)
{
    Console.Write("[");
    for(int i = 0; i < array.Length - 1; i++)
    {
        Console.Write(Math.Round(array[i], 2) + ", ");
    }
    Console.Write(Math.Round(array[array.Length - 1], 2) + "] -> " + Math.Round(difference, 2));
}

double DifferenceMaxMin(double[] array)
{
    double max = Max(array);
    double min = Min(array);
    return max - min;
}


double Min(double[] array)
{
    double min = array[0];
    for(int i = 1; i < array.Length; i++)
    {
        if (array[i] < min)
        {
            min = array[i];
            
        }
    }
    return min;
}

double Max(double[] array)
{
    double max = array[0];
    for(int i = 1; i < array.Length; i++)
    {
        if (array[i] > max)
        {
            max = array[i];
        }
    }
    return max;
}




void ArrayRandom(double[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().NextDouble() * (50 - (-50) + (-50));
    }

}
