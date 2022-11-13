// Задача 36: Задайте одномерный массив, 
//заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.

int[] Returns_Array(int size, int LeftValue, int RightValue)
{
    int[] vector = new int[size];
    for (int i = 0; i < size; i++)
    {
        vector[i] = new Random().Next(LeftValue, RightValue + 1);
    }
    return vector;
}

int Sum_of_Elements(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 != 0)
        {
            sum = sum + array[i];
        }
    }
    return sum;
}

Console.Clear();

Console.Write("Введите размер массива: ");
int number = int.Parse(Console.ReadLine()!);
Console.Write("Введите значение левого конца диапазона: ");
int a = int.Parse(Console.ReadLine()!);
Console.Write("Введите значение правого конца диапазона: ");
int b = int.Parse(Console.ReadLine()!);
int[] WorkingArray = Returns_Array(number, a, b);
Console.WriteLine($"Полученный массив: [{String.Join(", ", WorkingArray)}]");
Console.WriteLine($"Сумма элементов массива, стоящих на нечетных позициях равна {Sum_of_Elements(WorkingArray)}");