using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ML
{
    public class Weather
    {
        String outlook;
        String temp;
        String humidity;
        bool windy;
        bool playGolf;

        public Weather(String outlook, String temp, String humidity, bool windy, bool playGolf)
        {
            this.outlook = outlook;
            this.temp = temp;
            this.humidity = humidity;
            this.windy = windy;
            this.playGolf = playGolf;
        }

        public Weather()
        {
        }
        public String getOutlook()
        {
            return outlook;
        }
        public String getTemp()
        {
            return temp;
        }
        public string getHumidity()
        {
            return humidity;
        }
        public string getWindy()
        {
            return windy.ToString();
            //return (windy == true) ? "True" : "False";
        }
        public bool getPlay()
        {
            return playGolf;
        }
    }
}
