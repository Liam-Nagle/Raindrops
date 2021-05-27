using NUnit.Framework;
using Raindrops;

namespace RaindropTests
{
    public class Tests
    {
        //Simple Tests

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

        //Variations

        [TestCase(15)]
        [TestCase(30)]
        [TestCase(150)]
        [TestCase(-300)]
        public void PlingPlangPlong_MultiplesOf3And5_ReturnsPlingPlang(int number)
        {
            Assert.AreEqual("PlingPlang", RaindropsClass.PlingPlangPlong(number));
        }

        [TestCase(21)]
        [TestCase(42)]
        [TestCase(63)]
        [TestCase(-63)]
        public void PlingPlangPlong_MultiplesOf3And7_ReturnsPlingPlong(int number)
        {
            Assert.AreEqual("PlingPlong", RaindropsClass.PlingPlangPlong(number));
        }

        [TestCase(35)]
        [TestCase(70)]
        [TestCase(700)]
        [TestCase(-350)]
        public void PlingPlangPlong_MultiplesOf5And7_ReturnsPlangPlong(int number)
        {
            Assert.AreEqual("PlangPlong", RaindropsClass.PlingPlangPlong(number));
        }

        [TestCase(105)]
        [TestCase(210)]
        [TestCase(630)]
        [TestCase(-105)]
        public void PlingPlangPlong_MultiplesOf3And5And7_ReturnsPlingPlangPlong(int number)
        {
            Assert.AreEqual("PlingPlangPlong", RaindropsClass.PlingPlangPlong(number));
        }
    }
}