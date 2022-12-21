

int GetNumber(string message)
{
    int result;

    while (true)
    {
        Console.WriteLine(message);
        if (int.TryParse(Console.ReadLine(), out result))
        {
            break;
        }
        else
        {
            Console.WriteLine("Ввели не число.");
        }
    }

    return result;
}

int[] InitArray(int dimension)
{
    int[] array = new int[dimension];
    Random rnd = new Random();

    for (int i = 0; i < dimension; i++)
    {
        array[i] = rnd.Next(-99, 100);
    }

    return array;
}
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

int GetSumms(int[] array)
{
    int min = 0;
    int max = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < min)
            min = array[i];
        else
        if (array[i] > max)
            max = array[i];
    }
    int diff = max - min;

    return diff;
}


int dimension = GetNumber("Введите размерность массива");
int[] array = InitArray(dimension);
PrintArray(array);
int diffArray = GetSumms(array);

Console.WriteLine($"Разница между максимальным и минимальным элементом массива: {diffArray}");
