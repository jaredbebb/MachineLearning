using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ML
{
    public class WeatherTable
    {
        String[] outlookCol;
        String[] tempCol;
        String[] humidityCol;
        string[] windyCol;
        bool[] playGolfCol;

        public WeatherTable(String[] outlookCol, String[] tempCol, String[] humidityCol, string[] windyCol, bool[] playGolfCol)
        {
            this.outlookCol = outlookCol;
            this.tempCol = tempCol;
            this.humidityCol = humidityCol;
            this.windyCol = windyCol;
            this.playGolfCol = playGolfCol;
        }

        public WeatherTable(Weather[] weather)
        {
            setOutlook(weather);
            setTemp(weather);
            setHumidity(weather);
            setWindy(weather);
            setPlayGolf(weather);
        }

        public void setOutlook(Weather[] weather)
        {
            outlookCol = new string[weather.Length];
            for (int i = 0; i < weather.Length; i++)
            {
                String curr = weather[i].getOutlook();
                outlookCol[i] = curr;
            }
        }

        public string[] getOutlook()
        {
                return outlookCol;
        }
        public void setTemp(Weather[] weather)
        {
            tempCol = new string[weather.Length];
            for (int i = 0; i < weather.Length; i++)
            {
                String curr = weather[i].getTemp();
                tempCol[i] = curr;
            }
        }
        public string[] getTemp()
        {
            return tempCol;
        }

        public void setHumidity(Weather[] weather)
        {
            humidityCol = new string[weather.Length];
            for (int i = 0; i < weather.Length; i++)
            {
                String curr = weather[i].getHumidity();
                humidityCol[i] = curr;
            }
        }
        public string[] getHumidity()
        {
            return humidityCol;
        }
        public void setWindy(Weather[] weather)
        {
            windyCol = new string[weather.Length];
            for (int i = 0; i < weather.Length; i++)
            {
                string curr = weather[i].getWindy();
                windyCol[i] = curr;
            }
        }
        public string[] getWindy()
        {
            return windyCol;
        }

        public void setPlayGolf(Weather[] weather)
        {
            playGolfCol = new bool[weather.Length];
            for (int i = 0; i < weather.Length; i++)
            {
                bool curr = weather[i].getPlay();
                playGolfCol[i] = curr;
            }
        }
        public bool[] getPlayGolf()
        {
            return playGolfCol;
        }
    }
}
