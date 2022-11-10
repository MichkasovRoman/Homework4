// Задача 34: Задайте массив заполненный случайными
//положительными трёхзначными числами. Напишите
//программу, которая покажет количество чётных чисел в
//массиве.

int[] ThreeDigitNumbers(int size)
{
    int[] three_digit = new int[size];
    for (int i = 0; i < size; i++)
    {
        three_digit[i] = new Random().Next(100, 1000);
    }
    return three_digit;
}

int Quantity_of_EvenNumbers(int[] array)
{
    int count = 0;
    for (int i = 0; i <= array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            count ++;
            break;
        }
    }
    return count;
}

Console.Clear();

Console.Write("Введите размер массива: ");
int number = int.Parse(Console.ReadLine()!);
int[] WorkingArray = ThreeDigitNumbers(number);
Console.WriteLine($"Полученный массив: [{String.Join(", ", WorkingArray)}]");
Console.Write($"Количество четных чисел в массиве: {Quantity_of_EvenNumbers(WorkingArray)}");


