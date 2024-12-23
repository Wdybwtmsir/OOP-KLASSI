using System;

public class Time
{
    public int Hours { get; set; }
    public int Minutes { get; set; }

    public Time(int hours, int minutes)
    {
        Hours = hours;
        Minutes = minutes;
    }

    public string GetInfo()
    {
        return $"Количество часов: {Hours}, Количество минут: {Minutes}";
    }

    public int CalculateMinuti()
    {
        return (Hours * 60) + Minutes;
    }
}

class Program
{
    static void Main()
    {
        Console.Write("Введите количество часов: ");
        int hours = int.Parse(Console.ReadLine());

        Console.Write("Введите количество минут: ");
        int minutes = int.Parse(Console.ReadLine());

        Time time = new Time(hours, minutes);

        Console.WriteLine(time.GetInfo());

        int totalMinutes = time.CalculateMinuti();
        Console.WriteLine($"Общее количество минут: {totalMinutes}");
    }
}