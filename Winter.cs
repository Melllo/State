using System;
using System.Collections.Generic;
using System.Text;

namespace State
{
    class Winter : ISeason
    {
        public void makeWeather()
        {
            Console.WriteLine("Winter!");
        }
    }
}
