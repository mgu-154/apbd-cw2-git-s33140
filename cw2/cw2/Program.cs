Console.WriteLine("Hello, World!");

string val = Console.ReadLine();
if (val is not null) {
    Console.WriteLine(val);
}
else
{
    Console.WriteLine("Uzytkownik nic nie wpisal");
}

static double CalculateAverage(int[] values)
{
    double average = values.Average();
    return average;
}

static double CalculateMax(int[] values)
{
    double max = values.Max();
    return max;
}

static double CalculateMin(int[] values)
{
    double min = values.Min();
    return min * 10;
}