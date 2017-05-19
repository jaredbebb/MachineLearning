using System;
using Xunit;


namespace ML.Tests
{
    public class DecisionTree_IsDT
    {
        [Fact]
        public void EntropyTest1()
        {
            double p = 0.5;
            double n = 0.5;
		    DecisionTrees DT = new DecisionTrees();
            double e = DT.Entropy(p,n);
            Assert.Equal(e, 1.0);
		    //var result = false;
		    //Assert.False(result, $"result should not be true"); 
        }
        [Fact]
        public void EntropyTest2()
        {
            double p = 1;
            double n = 0;
            DecisionTrees DT = new DecisionTrees();
            double e = DT.Entropy(p, n);
            Assert.Equal(e, 0);
        }
        [Fact]
        public void EntropyTest3()
        {
            double p = .2;
            double n = .8;
            DecisionTrees DT = new DecisionTrees();
            double e = DT.Entropy(p, n);
            Assert.Equal(e, .72,2);
        }

    }
}
