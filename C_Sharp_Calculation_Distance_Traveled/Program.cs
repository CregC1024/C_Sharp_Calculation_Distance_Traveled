//C# program to calculate the traveled distance 
//based on speed and time.

using System;

class Demo
{
    static int CalculatDistance(int speed, int time)
    {
        int distance = 0;

        distance = speed * time;

        return distance;
    }
    static void Main(string[] args)
    {
        int speed = 0;
        int timeInHours = 0;
        int distance = 0;

        Console.Write("Enter time in hours: ");
#pragma warning disable CS8604 // Possible null reference argument.
        timeInHours = int.Parse(s: Console.ReadLine());
#pragma warning restore CS8604 // Possible null reference argument.

        Console.Write("Enter speed in miles per hour: ");
#pragma warning disable CS8604 // Possible null reference argument.
        speed = int.Parse(Console.ReadLine());
#pragma warning restore CS8604 // Possible null reference argument.

        distance = CalculatDistance(speed, timeInHours);
        Console.WriteLine("Traveled distance in miles: " + distance);
    }
}

