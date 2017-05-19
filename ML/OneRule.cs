using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ML
{

    public class OneRule
    {
        private String[] attribute;
        private bool[] play;
        private int classError;
        Dictionary<String, Decision> classCount;
        private string name = "DEFAULT";

        //parameters passed by ref
        public OneRule(ref String[] attribute, ref bool[] play, string name)
        {
            this.attribute = attribute;
            this.play = play;
            this.classError = int.MaxValue;
            this.name = name;
        }

        public OneRule()
        {
            this.classError = int.MaxValue;
        }

        public void setClassError()
        {
            Decision d;
            foreach (KeyValuePair<String, Decision> item in classCount)
            {
                d = item.Value;
                classError += d.getError();
            }
        }

        public int getClassError()
        {
            return classError;
        }

        public String[] getAttribute()
        {
            return attribute;
        }

        public void setAttribute(ref String[] attribute)
        {
            this.attribute =  attribute;
        }

        public bool[] getPlay()
        {
            return play;
        }

        public string getName()
        {
            return name;
        }

        public Dictionary<String, Decision> setClassCount()
        {
            String[] attr = getAttribute();
            bool[] pl = this.play;
            classCount = new Dictionary<string, Decision>();
            Decision currDC;
            for (int i = 0; i < attribute.Length; i++)
            {
                String currAttr = attr[i];
                bool currPlay = pl[i];
                //new decision count to add to dictionary
                Decision dcToAdd = new Decision();
                if (!classCount.TryGetValue(currAttr, out currDC))
                {
                    dcToAdd.setYes((currPlay == true) ? 1:  0);
                    dcToAdd.setNo((currPlay == false) ? 1 : 0);
                    dcToAdd.setError();
                    classCount.Add(currAttr, dcToAdd);
                }
                //if diction has key, then modify yes/no
                else if(classCount.TryGetValue(currAttr, out currDC))
                {
                    //gets the decision values for yes and no
                    int yesCount = currDC.getYes();
                    int noCount = currDC.getNo();
                    currDC.setYes((currPlay == true) ? yesCount+1 : yesCount);
                    currDC.setNo((currPlay == false) ? noCount + 1 : noCount);
                    currDC.setError();
                }
                else
                {
                    Console.WriteLine("something is wrong in SetClassCount()");
                }
            }
            return classCount;
        }
   
        public void getClassCount()
        {
            classError = 0;
            foreach(KeyValuePair<String, Decision> item in classCount)
            {
                String s = item.Key;
                Decision d = item.Value;
                Console.WriteLine("Key: {0}, Yes: {1}, No: {2}, Error: {3}", s, d.getYes(),d.getNo(), d.getError());
                classError += d.getError();
            }
            Console.WriteLine("Error:{0}",classError);
        }
    }
}
