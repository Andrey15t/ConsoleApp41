int[] numbers = { 1, -2, 3, 5, -1, 2, -3, -5 };

//кол-во отрицательных чисел
int countNegative = 0;
//кол-во положительных чисел
int countPositive = 0;

//подсчёт кол-ва отрицательных чисел
for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] < 0)
    {
        countNegative++;
    }
}

//подсчёт кол-ва положительных чисел
for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] > 0)
    {
        countPositive++;
    }
}

//массив только отрицательных чисел
int[] negativeNumbers = new int[countNegative];
for (int i = 0, j = 0; i < numbers.Length; i++)
{
    if (numbers[i] < 0)
    {
        negativeNumbers[j] = numbers[i];
        j++;
    }
}

//массив только положительных чисел
int[] positiveNumbers = new int[countPositive];
for (int i = 0, j = 0; i < numbers.Length; i++)
{
    if (numbers[i] > 0)
    {
        positiveNumbers[j] = numbers[i];
        j++;
    }
}

Console.WriteLine($"Max negative value: {negativeNumbers.Max()}");
Console.WriteLine($"Mix positive value: {positiveNumbers.Min()}");




Console.ReadKey();