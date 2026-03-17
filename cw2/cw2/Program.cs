Console.WriteLine("Hello, World!");

string text = Console.ReadLine();
if (text is not null) {
    Console.WriteLine(text);
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