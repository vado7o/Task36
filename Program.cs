// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

Console.Clear();
Console.WriteLine("Программа, показывающая сумму элементов массива, стоящих на нечётных позициях.");

int size = 0;

while (true)
{
    Console.Write("\nНапишите - из скольки элементов должен состоять массив? : ");
    if (int.TryParse(Console.ReadLine(), out int number))
    {
        if (number > 0)
        {
            size = number;
            break;
        }
        else Console.WriteLine("Некорректно указано количество элементов первого массива!\n");
    }
    else Console.WriteLine("Некорректно указано количество элементов первого массива!\n");
}

int[] array = FillArray(size, 1, 100);
Console.Write("\nВ сгенерированном массиве");
PrintArray(array);
Console.WriteLine(" сумма элементов, стоящих на нечётных позициях равна " + CountSum(array));


int[] FillArray(int size, int min, int max)
{
    int[] filledArray = new int[size];
    for (int index = 0; index < size; index++)
    {
        filledArray[index] = new Random().Next(min, max);
    }
    return filledArray;
}

void PrintArray(int[] array)
{
    Console.Write(" [" + String.Join(", ", array) + "]");
}

int CountSum(int[] array)
{
    int count = 0;
    int index = 1;
    while(index < size)
    {
        count += array[index];
        index+=2;
    }
    return count;
}