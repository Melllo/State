using System;
using System.Collections.Generic;
using System.Text;

namespace State
{
    class Fall : ISeason
    {
        public void makeWeather()
        {
            Console.WriteLine("Fall!");
        }
    }
}
