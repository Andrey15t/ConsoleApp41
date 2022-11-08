int[] numbers = { 1, -2, 3, 5, -1, 2, -3, -5 };

int countNegative = 0;
int countPositive = 0;

for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] < 0)
    {
        countNegative++;
    }
}

for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] > 0)
    {
        countPositive++;
    }
}

int[] negativeNumbers = new int[countNegative];
for (int i = 0, j = 0; i < numbers.Length; i++)
{
    if (numbers[i] < 0)
    {
        negativeNumbers[j] = numbers[i];
        j++;
    }
}

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