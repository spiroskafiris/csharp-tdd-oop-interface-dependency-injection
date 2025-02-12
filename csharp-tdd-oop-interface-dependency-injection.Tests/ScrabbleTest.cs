﻿using NUnit.Framework;
using tdd_oop_interface_dependency_injection.CSharp.Main;

namespace tdd_oop_interface_dependency_injection.CSharp.Test
{

        [TestFixture]
        public class ScrabbleTest {
        [Test]
        public void shouldGive0ForEmptyWords() {
            IAlphabet alphabet = new EnglishAlphabet();
            Scrabble scrabble = new Scrabble(alphabet);
            Assert.AreEqual(0, scrabble.score(""));
        }

        [Test]
        public void shouldGive0ForWhiteSpace() {
            IAlphabet alphabet = new EnglishAlphabet();
            Scrabble scrabble = new Scrabble(alphabet);
            Assert.AreEqual(0, scrabble.score("\n\r\t\b\f"));
        }

        [Test]
        public void shouldScore1ForA() {
            IAlphabet alphabet = new EnglishAlphabet();
            Scrabble scrabble = new Scrabble(alphabet);
            Assert.AreEqual(1, scrabble.score("a"));
        }

        [Test]
        public void shouldScore4ForF() {
            IAlphabet alphabet = new EnglishAlphabet();
            Scrabble scrabble = new Scrabble(alphabet);
            Assert.AreEqual(4, scrabble.score("f"));
        }

        [Test]
        public void shouldScore6ForStreet() {
            IAlphabet alphabet = new EnglishAlphabet();
            Scrabble scrabble = new Scrabble(alphabet);
            Assert.AreEqual(6, scrabble.score("street"));
        }

        [Test]
        public void shouldScore22ForQuirky() {
            IAlphabet alphabet = new EnglishAlphabet();
            Scrabble scrabble = new Scrabble(alphabet);
            Assert.AreEqual(22, scrabble.score("quirky"));
        }

        [Test]
        public void shouldScoreRussianLetters() {
            IAlphabet alphabet = new RussianAlphabet();
            Scrabble scrabble = new Scrabble(alphabet);
            Assert.AreEqual(18, scrabble.score("дврфъ"));
        }

        [Test]
        public void shouldScoreGreekLetters() {
            IAlphabet alphabet = new GreekAlphabet();
            Scrabble scrabble = new Scrabble(alphabet);
            Assert.AreEqual(20, scrabble.score("φεψωλ"));
        }
    }
}