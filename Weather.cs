using System;
using System.Collections.Generic;
using System.Text;

namespace State
{
    class Weather
    {
        ISeason season;

        public Weather(ISeason season) {
            this.season = season;
        }
        public void setSeason(ISeason season) {
            this.season = season;
        }

        public ISeason getSeason() {
            return season;
        }

        public void changingSeason(){
            if (season is Winter) 
            {
                this.setSeason(new Spring());
            } else if (season is Spring)
            {
                this.setSeason(new Summer());
            } else if (season is Summer) 
            {
                this.setSeason(new Fall());
            } else if (season is Fall)
            {
                this.setSeason(new Winter());
            }
        }
        public void makeWaether() {
            season.makeWeather();
        }
    }
}
