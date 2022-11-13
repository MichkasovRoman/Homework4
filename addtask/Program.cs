// Задача "со звездочкой": Разобраться с алгоритмом сортировки методом пузырька. 
//Реализовать невозрастающую сторировку.

double[] Returns_Array(int size, int left, int right)
{
    double[] vector = new double[size];
    for (int i = 0; i < size; i++)
    {
        vector[i] = Math.Round(new Random().NextDouble() * (right - left) + left, 5);
    }
    return vector;
}

double[] Sorted_Array(double[] array)
{
    for (int i = 1; i < array.Length; i++)
    {
        for (int k = 0; k < array.Length - i; k++)
        {
            if (array[k] <= array[k + 1])
            {
                double temp = array[k];
                array[k] = array[k + 1];
                array[k + 1] = temp;
            }
        }
    }
    return array;
}

Console.Clear();

Console.Write("Введите размер массива: ");
int number = int.Parse(Console.ReadLine()!);
Console.Write("Введите значение левого конца диапазона: ");
int a = int.Parse(Console.ReadLine()!);
Console.Write("Введите значение правого конца диапазона: ");
int b = int.Parse(Console.ReadLine()!);
double[] WorkingArray = Returns_Array(number, a, b);
Console.WriteLine($"Полученный массив: [{String.Join(", ", WorkingArray)}]");

double[] NewArray = Sorted_Array(WorkingArray);
Console.WriteLine($"Отсортированный массив: [{String.Join(", ", NewArray)}]");
