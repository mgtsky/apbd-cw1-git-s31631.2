namespace StatisticsApp;

public static class StatisticsHelper
{
    public static double CalculateAverage(int[] values)
    {
        if(values.Length == 0)
            return 0;

        return values.Sum() / (double)values.Length;    }
    public static int CalculateMax(int[] values)
    {
        return values.Max();
    }
}