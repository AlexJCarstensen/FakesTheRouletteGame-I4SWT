using System.Collections.Generic;
using NSubstitute;
using NUnit.Framework;
using RouletteGame.Roulette;

namespace RouletteGame.Test.Unit
{
    [TestFixture]
    public class RouletteUnitTest
    {
        private Roulette.Roulette _uut;

        [SetUp]
        public void Setup()
        {
            _uut = new Roulette.Roulette();
        }
        [Test]
        public void Spin_()
        {
            _uut.Spin();
            var test = _uut.GetResult();
            Assert.That(test.Number, Is.InRange(0,37));
        }
    }
}