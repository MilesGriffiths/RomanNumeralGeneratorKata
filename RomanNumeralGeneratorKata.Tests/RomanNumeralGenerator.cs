using NUnit.Framework;

namespace RomanNumeralGeneratorKata.Tests
{
    public class RomanNumeralGeneratorShould
    {
        [Test]
        [TestCase(1, "I")]
        [TestCase(4, "IV")]
        [TestCase(5, "V")]
        [TestCase(6, "VI")]
        [TestCase(9, "IX")]
        [TestCase(29, "XXIX")]
        [TestCase(80, "LXXX")]
        [TestCase(294, "CCXCIV")]
        [TestCase(2019, "MMXIX")]
        public void WhenCalledWithAnInteger_ReturnRomanNumerals(int integer, string expectedResults)
        {
            Assert.That(RomanNumeralGenerator.GetNumeral(integer), Is.EqualTo(expectedResults));
        }
    }
}