using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ML
{
    public class DecisionTrees
    {
        /**Algorithm(ID#)
         * 1. ID3
         * Entropy
         * 1.Use frequency table of one attribute
         * 2.Entropy using the frequency table of two attributes
         * Information Gain
         * 1.Calculate entropy of the target
         * 2.Dataset is split on different attributes
         * 3. Choose attribute with largest information gain
         * 4. Run ID3 alg on each non-leaf branches until all the data is classified
         * Decision Tree to Decision Rules
         * 1. Transorm tree to set of rules
         * */


         /**
          * Basic Divide and Conquer Algorithm
          * 1. select a test for root node
          *     Create branch for each possible outcome for test
          * 2. split instances into subsets
          *     One for each branch extending from node
          * 3. repeat recursively for each branch, using only instances that reach
          * the branch
          * 4. stop recursion for a branch if all its instances have the same class
          * */

        public Tree IDThree(int[] example, Node head)
        {
            Node x = new Node(head.getKey());
            Tree DT = new Tree(x);

            return DT;
        }

        public Node ID3(int [] examples, string[] attributes, int possibleValues)
        {
            //x = root
            Node x = new Node(1);
            if (CheckExamplesPositive(examples) == true)
            {
                x.label = "+";
            }
            if (CheckExamplesNegative(examples) == true)
            {
                x.label = "-";
            }
            if (attributes.Length == 0)
            {
                return x;
            }
            string a = "attribute that best classifies examples";
            x.label = a;
            for (int i = 0; i < Factorial(possibleValues); i++ )
            {
                Node j = new Node(2);
                x.setLeft(j);
                int e = examples[i];
                if (e == 0)
                {
                    Node eN = new Node(3);
                    j.setLeft(eN);
                }
                else
                {
                    Node f = new Node(4);
                    j.setLeft(f);
                }

                x = j;
            }
            return x;
        }

        public Boolean CheckExamplesPositive(int [] examples)
        {
            return true;
        }
        public Boolean CheckExamplesNegative(int[] examples)
        {
            return true;
        }

        public int Factorial(int toBeFactorialed)
        {
            int f = 0;
            for (int i = toBeFactorialed; i >0; i++)
            {
                f +=  i;
            }
            return f;
        }

        /**
         * Entropy = (-PrPositive X logbase2 PrPositive)+(-PrNegative X logbase2 PrNegative) 
         * 
         **/
        public Double Entropy(Double PrPositive,Double PrNegative)
        {
            double ent;
            if ((PrPositive == 1.0) && (PrNegative == 0.0))
            {
                ent = 0.0;
                return ent;
            }
            if ((PrNegative == 1.0) && (PrPositive == 0.0))
            {
                ent = 0.0;
                return ent;
            }
            else
            {
                double logBase = 2.0;
                ent = (-PrPositive * Math.Log(PrPositive, logBase)) - (PrNegative * Math.Log(PrNegative, logBase));
                return ent;
            }

        }
    }

}
