using NUnit.Framework;
using Pling;

namespace PlingTest
{
    public class PlangTests
    {
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void Plong_IfNumberEnteredEqualsZero_ReturnPlingPlangPlong()
        {
            Assert.That("PlingPlangPlong", Is.EqualTo(Plang.Plong(0)));
        }

        [TestCase(-1, "-1")]
        [TestCase(-1, "-1")]
        [TestCase(34, "34")]
        [TestCase(-34, "-34")]
        [TestCase(19, "19")]
        public void Plong_IfNumberHasNoRelevantFactor_ReturnNumber(int input, string expectedResult)
        {
            var result = Plang.Plong(input);
            Assert.That(expectedResult, Is.EqualTo(result));
        }

        [TestCase(-3, "Pling")]
        [TestCase(3, "Pling")]
        [TestCase(18, "Pling")]
        [TestCase(-18, "Pling")]
        public void IfNumberHasAFactorOf3_ReturnPling(int input, string expectedResult)
        {
            var result = Plang.Plong(input);
            Assert.That(expectedResult, Is.EqualTo(result));
        }

        [TestCase(5, "Plang")]
        [TestCase(-5, "Plang")]
        [TestCase(25, "Plang")]
        [TestCase(-25, "Plang")]
        public void IfNumberHasAFactorOf5_ReturnPlang(int input, string expectedResult)
        {
            var result = Plang.Plong(input);
            Assert.That(expectedResult, Is.EqualTo(result));
        }

        [TestCase(-7, "Plong")]
        [TestCase(7, "Plong")]
        [TestCase(49, "Plong")]
        [TestCase(-49, "Plong")]
        public void IfNumberHasAFactorOf7_ReturnPlong(int input, string expectedResult)
        {
            var result = Plang.Plong(input);
            Assert.That(expectedResult, Is.EqualTo(result));
        }

        //All 3 Together
        [TestCase(105, "PlingPlangPlong")]
        [TestCase(-105, "PlingPlangPlong")]
        [TestCase(210, "PlingPlangPlong")]
        [TestCase(-210, "PlingPlangPlong")]
        public void IfNumberHasAFactorOf357_ReturnPlingPlangPlong(int input, string expectedResult)
        {
            var result = Plang.Plong(input);
            Assert.That(expectedResult, Is.EqualTo(result));
        }

        //Variations
        [TestCase(15, "PlingPlang")]
        [TestCase(-15, "PlingPlang")]
        [TestCase(60, "PlingPlang")]
        [TestCase(-60, "PlingPlang")]
        public void IfNumberHasAFactorOf3_5_ReturnPlingPlang(int input, string expectedResult)
        {
            var result = Plang.Plong(input);
            Assert.That(expectedResult, Is.EqualTo(result));
        }

        [TestCase(21, "PlingPlong")]
        [TestCase(-21, "PlingPlong")]
        [TestCase(84, "PlingPlong")]
        [TestCase(-84, "PlingPlong")]
        public void IfNumberHasAFactorOf3_7_ReturnPlingPlong(int input, string expectedResult)
        {
            var result = Plang.Plong(input);
            Assert.That(expectedResult, Is.EqualTo(result));
        }

        [TestCase(35, "PlangPlong")]
        [TestCase(-35, "PlangPlong")]
        [TestCase(140, "PlangPlong")]
        [TestCase(-140, "PlangPlong")]
        public void IfNumberHasAFactorOf5_7_ReturnPlangPlong(int input, string expectedResult)
        {
            var result = Plang.Plong(input);
            Assert.That(expectedResult, Is.EqualTo(result));
        }      
    }
}