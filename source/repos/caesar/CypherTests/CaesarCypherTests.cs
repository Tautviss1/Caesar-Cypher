using Microsoft.VisualStudio.TestTools.UnitTesting;
using caesar;

namespace CypherTests
{
    [TestClass]
    public class CaesarCypherTests
    {
        [TestMethod]
        public void Encrypt_WithValidLetters()
        {
            string text = "ABCD";
            string expected = "CDEF";
            int shift = 2;
            string actual = Cypher.Encrypt(text,shift);
            Assert.AreEqual(expected,actual,"Wrong Encrypt Method");

        }
        [TestMethod]
        public void Encrypt_WithAWord()
        {
            string text = "LABAS";
            string expected = "QFGFX";
            int shift = 5;
            string actual = Cypher.Encrypt(text, shift);
            Assert.AreEqual(expected, actual, "Wrong Encrypt Method");

        }
        [TestMethod]
        public void Decrypt_WithAWord()
        {
            string text = "QFGFX";
            string expected = "LABAS";
            int shift = 5;
            string actual = Cypher.Decrypt(text, shift);
            Assert.AreEqual(expected, actual, "Wrong Encrypt Method");

        }
        [TestMethod]
        public void Encrypt_WithoutLetters()
        {
            string text = "";
            string expected = "";
            int shift = 2;
            string actual = Cypher.Encrypt(text, shift);
            Assert.AreEqual(expected, actual, "Wrong Encrypt Method");

        }
        [TestMethod]
        public void Encrypt_WithBigShift()
        {
            string text = "ABCD";
            string expected = "YZAB";
            int shift = 24;
            string actual = Cypher.Encrypt(text, shift);
            Assert.AreEqual(expected, actual, "Wrong Encrypt Method");

        }
        [TestMethod]
        public void Decrypt_WithBigShift()
        {
            string text = "YZAB";
            string expected = "ABCD";
            int shift = 24;
            string actual = Cypher.Decrypt(text, shift);
            Assert.AreEqual(expected, actual, "Wrong Decrypt Method");

        }
        [TestMethod]
        public void Decrypt_WithValidLetters()
        {
            string text = "CDEF";
            string expected = "ABCD";
            int shift = 2;
            string actual = Cypher.Decrypt(text, shift);
            Assert.AreEqual(expected, actual, "Wrong Decrypt Method");

        }
        [TestMethod]
        public void Decrypt_WithoutLetters()
        {
            string text = "";
            string expected = "";
            int shift = 2;
            string actual = Cypher.Decrypt(text, shift);
            Assert.AreEqual(expected, actual, "Wrong Decrypt Method");

        }
    }
}
