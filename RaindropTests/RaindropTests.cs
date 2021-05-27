using NUnit.Framework;
using Raindrops;

namespace RaindropTests
{
    public class Tests
    {
        [TestCase(3)]
        [TestCase(6)]
        [TestCase(57)]
        [TestCase(-33)]
        public void PlingPlangPlong_MultiplesOf3_ReturnsPling(int number)
        {
            Assert.AreEqual("Pling", RaindropsClass.PlingPlangPlong(number));
        }

        [TestCase(5)]
        [TestCase(10)]
        [TestCase(50)]
        [TestCase(-40)]
        public void PlingPlangPlong_MultiplesOf5_ReturnsPlang(int number)
        {
            Assert.AreEqual("Plang", RaindropsClass.PlingPlangPlong(number));
        }

        [TestCase(7)]
        [TestCase(14)]
        [TestCase(77)]
        [TestCase(-49)]
        public void PlingPlangPlong_MultiplesOf7_ReturnsPlong(int number)
        {
            Assert.AreEqual("Plong", RaindropsClass.PlingPlangPlong(number));
        }

        [TestCase(4)]
        [TestCase(11)]
        [TestCase(38)]
        [TestCase(-379)]
        public void PlingPlangPlong_MultiplesOfNone_ReturnsTheNumber(int number)
        {
            Assert.AreEqual(number.ToString(), RaindropsClass.PlingPlangPlong(number));
        }

    }
}