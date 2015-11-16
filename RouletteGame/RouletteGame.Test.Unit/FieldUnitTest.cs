using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using RouletteGame.Roulette;

namespace RouletteGame.Test.Unit
{
    [TestFixture]
    public class FieldUnitTest
    {
        private IField _uut;

        [Test]
        public void ToString_Field5Green_returnCorrectString()
        {
            _uut = new Field(5, Field.Green);

            var correctString = _uut.ToString();

            Assert.That(correctString, Is.EqualTo("[5, green]"));
        }

        [Test]
        public void ToString_Field27Black_returnCorrectString()
        {
            _uut = new Field(27, Field.Black);

            var correctString = _uut.ToString();

            Assert.That(correctString, Is.EqualTo("[27, black]"));
        }

        [Test]
        public void ToString_Field10Red_returnCorrectString()
        {
            _uut = new Field(10, Field.Red);

            var correctString = _uut.ToString();
            
            Assert.That(correctString, Is.EqualTo("[10, red]"));
        }
    }
}
