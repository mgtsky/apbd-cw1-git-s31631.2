using StatisticsApp;


Console.WriteLine("Enter numbers separated by space:");

string input = Console.ReadLine();

string[] parts = input.Split(" ");

int[] numbers = parts.Select(int.Parse).ToArray();

double avg = StatisticsHelper.CalculateAverage(numbers);

Console.WriteLine("Average: " + avg);