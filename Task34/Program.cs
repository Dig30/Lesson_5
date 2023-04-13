/*Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
Напишите программу, которая покажет количество чётных
 чисел в массиве.
[345, 897, 568, 234] -> 2*/


int[] array = new int[6];
ArrayRandom(array);
int result = AmountEvenNambers(array);
ArrayPrintConsole(array, result);

void ArrayPrintConsole(int[] array, int countEven)
{
    Console.Write("[");
    for(int i = 0; i < array.Length - 1; i++)
    {
        Console.Write(array[i] + ", ");
    }
    Console.Write(array[array.Length - 1] + "] -> " + countEven);
}



int AmountEvenNambers(int[] array)
{
    int count = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            count++;
        } 
    }
    return count;
}




void ArrayRandom(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100, 1000);   
    }

}   
