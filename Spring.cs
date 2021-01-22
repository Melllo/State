using System;
using System.Collections.Generic;
using System.Text;

namespace State
{
    class Spring : ISeason
    {
        public void makeWeather()
        {
            Console.WriteLine("Spring!");
        }
    }
}
