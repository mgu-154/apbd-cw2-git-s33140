Console.WriteLine("Hello, World!");

string napis = Console.ReadLine();
if (napis is not null) {
    Console.WriteLine(napis);
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