using System.Linq;
using StatisticsApp;

Console.WriteLine("Statistics calculator started");

string input = Console.ReadLine();

if (string.IsNullOrEmpty(input))
{
    Console.WriteLine("Input cannot be empty.");
    return;
}

string[] parts = input.Split(" ");
int[] numbers = parts.Select(int.Parse).ToArray();

double avg = StatisticsHelper.CalculateAverage(numbers);

Console.WriteLine("Average: " + avg);