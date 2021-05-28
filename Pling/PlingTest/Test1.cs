using NUnit.Framework;
using Pling;

namespace PlingTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void IfNumberEnteredEqualsZero()
        {
            Assert.That("PlingPlangPlong", Is.EqualTo(Plang.Plong(0)));
        }

        [TestCase(-17, "-17")]
        [TestCase(-19, "-19")]
        [TestCase(34, "34")]
        [TestCase(-34, "-34")]
        [TestCase(19, "19")]
        public void IfNumberHasNoRelevantFactorReturnNumber(int input, string expectedResult)
        {
            var result = Plang.Plong(input);
            Assert.That(expectedResult, Is.EqualTo(result));
        }

        [TestCase(-3, "Pling")]
        [TestCase(3, "Pling")]
        [TestCase(18, "Pling")]
        [TestCase(-18, "Pling")]
        public void IfNumberHasAFactorOf_3(int input, string expectedResult)
        {
            var result = Plang.Plong(input);
            Assert.That(expectedResult, Is.EqualTo(result));
        }

        [TestCase(5, "Plang")]
        [TestCase(-5, "Plang")]
        [TestCase(25, "Plang")]
        [TestCase(-25, "Plang")]
        public void IfNumberHasAFactorOf_5(int input, string expectedResult)
        {
            var result = Plang.Plong(input);
            Assert.That(expectedResult, Is.EqualTo(result));
        }

        [TestCase(-7, "Plong")]
        [TestCase(7, "Plong")]
        [TestCase(49, "Plong")]
        [TestCase(-49, "Plong")]
        public void IfNumberHasAFactorOf_7(int input, string expectedResult)
        {
            var result = Plang.Plong(input);
            Assert.That(expectedResult, Is.EqualTo(result));
        }

        //All 3 Together
        [TestCase(105, "PlingPlangPlong")]
        [TestCase(-105, "PlingPlangPlong")]
        [TestCase(210, "PlingPlangPlong")]
        [TestCase(-210, "PlingPlangPlong")]
        public void IfNumberHasAFactorOf_3_5_7(int input, string expectedResult)
        {
            var result = Plang.Plong(input);
            Assert.That(expectedResult, Is.EqualTo(result));
        }

        //Variations
        [TestCase(15, "PlingPlang")]
        [TestCase(-15, "PlingPlang")]
        [TestCase(60, "PlingPlang")]
        [TestCase(-60, "PlingPlang")]
        public void IfNumberHasAFactorOf_3_5(int input, string expectedResult)
        {
            var result = Plang.Plong(input);
            Assert.That(expectedResult, Is.EqualTo(result));
        }

        [TestCase(21, "PlingPlong")]
        [TestCase(-21, "PlingPlong")]
        [TestCase(84, "PlingPlong")]
        [TestCase(-84, "PlingPlong")]
        public void IfNumberHasAFactorOf_3_7(int input, string expectedResult)
        {
            var result = Plang.Plong(input);
            Assert.That(expectedResult, Is.EqualTo(result));
        }

        [TestCase(35, "PlangPlong")]
        [TestCase(-35, "PlangPlong")]
        [TestCase(140, "PlangPlong")]
        [TestCase(-140, "PlangPlong")]
        public void IfNumberHasAFactorOf_5_7(int input, string expectedResult)
        {
            var result = Plang.Plong(input);
            Assert.That(expectedResult, Is.EqualTo(result));
        }      
    }
}