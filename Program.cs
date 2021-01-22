using System;

namespace State
{
    class Program
    {
        static void Main(string[] args)
        {
            Weather weather = new Weather(new Fall());
            Console.WriteLine("Current season is "+weather.getSeason() + "\nRun the cycles of seasons: ");
            for (int i =0; i<=12;i++) {
                weather.makeWaether();
                weather.changingSeason();
            }
        }
    }
}
