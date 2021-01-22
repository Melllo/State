using System;
using System.Collections.Generic;
using System.Text;

namespace State
{
    class Summer : ISeason
    {
        public void makeWeather()
        {
            Console.WriteLine("Summer!");
        }
    }
}
