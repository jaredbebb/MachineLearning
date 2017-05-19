using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace ML.Tests
{
    public class OneRuleTest
    {
        [Fact]
        public void ORTest()
        {
            Weather one = new Weather("Rainy", "Hot", "High", false, false);
            Weather two = new Weather("Rainy", "Hot", "High", true, false);
            Weather three = new Weather("Overcast", "Hot", "High", false, true);
            Weather four = new Weather("Sunny", "Mild", "High", false, true);
            Weather five = new Weather("Sunny", "Cool", "Normal", false, true);
            Weather six = new Weather("Sunny", "Cool", "Normal", true, false);
            Weather seven = new Weather("Overcast", "Cool", "Normal", true, true);
            Weather eight = new Weather("Rainy", "Mild", "High", false, false);
            Weather nine = new Weather("Rainy", "Cool", "Normal", false, true);
            Weather ten = new Weather("Sunny", "Mild", "Normal", false, true);
            Weather eleven = new Weather("Rainy", "Mild", "Normal", true, true);
            Weather twelve = new Weather("Overcast", "Mild", "High", true, true);
            Weather thirteen = new Weather("Overcast", "Hot", "Normal", false, true);
            Weather fourteen = new Weather("Sunny", "Mild", "High", true, false);
            Weather[] weather = { one, two, three, four, five, six, seven, eight,
            nine, ten, eleven, twelve, thirteen, fourteen};

            WeatherTable wt = new WeatherTable(weather);
            string[] outLook = wt.getOutlook();
            string[] temp = wt.getTemp();
            string[] humidity = wt.getHumidity();
            string[] windy = wt.getWindy();
            bool[] playgolf = wt.getPlayGolf();

            object[] stuff = { outLook, temp, humidity, windy };

            //params passed by reference
            OneRule OR1 = new OneRule(ref outLook, ref playgolf, "outlook");
            OneRule OR2 = new OneRule(ref temp, ref playgolf, "temp");
            OneRule OR3 = new OneRule(ref humidity, ref playgolf, "humidity");
            OneRule OR4 = new OneRule(ref windy, ref playgolf, "windy");


            OR1.setClassCount();
            OR1.getClassCount();

            OR2.setClassCount();
            OR2.getClassCount();

            OR3.setClassCount();
            OR3.getClassCount();

            OR4.setClassCount();
            OR4.getClassCount();

            OneRule[] decide = { OR1, OR2, OR3, OR4 };

            OneRule prog = new OneRule();
            OneRule chosen = prog.WhichClass(decide);

            
            Assert.Equal(chosen.getName(), "outlook");
            Assert.NotEqual(chosen.getName(), "windy");
            Assert.Equal(chosen.getClassError(), 4);


            //Console.WriteLine("Chosen: {0}, error is: {1}",chosen.getName(), chosen.getClassError());


            //Assert.Equal(e, 1.0);
        }
    }
}
