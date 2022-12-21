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
        array[i] = rnd.Next(-99, 1000);
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

int GetEvenSumm(int[] array)
{
    int summ = 0;

    for (int i = 0; i < array.Length; i = i + 2)
    {
        summ += array[i];
    }

    return summ;
}

int dimension = GetNumber("Введите размерность массива");
int[] array = InitArray(dimension);
PrintArray(array);
int oddSumm = GetEvenSumm(array);

Console.WriteLine($"Сумма элементов стоящих на нечётных позициях: {oddSumm}.");
