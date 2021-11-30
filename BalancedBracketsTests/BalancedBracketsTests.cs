using Microsoft.VisualStudio.TestTools.UnitTesting;
using BalancedBracketsNS;

namespace BalancedBracketsTests
{
    [TestClass]
    public class BalancedBracketsTests
    {
        // TODO: Add tests to this file.

        [TestMethod]
        public void EmptyTest()
        {
            Assert.AreEqual(true, true);
        }

        [TestMethod]
        public void OnlyBracketsReturnsTrue()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("[]"));
        }

        [TestMethod]
        public void EmptyStringReturnsTrue()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets(""));
        }

        [TestMethod]
        public void SingleOpeningBracketReturnsFalse()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("["));
        }

        [TestMethod]
        public void SingleClosingBracketReturnsFalse()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("]"));
        }

        [TestMethod]
        public void OppositeBracketsReturnFalse()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("]["));
        }

        [TestMethod]
        public void ManyBracketPairsReturnsTrue()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("[][][][][][][][]"));
        }

        [TestMethod]
        public void BalancedBracketsInBracketsReturnsTrue()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("[[[[[[[]]]]]]]"));
        }

        [TestMethod]
        public void NonBracketCharactersDoNotInterfere()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("   [a]b[c]d[e]f[1]2[3]4[5]6[!]@[#]$"));
        }


        [TestMethod]
        public void CharactersBeforeSingleBracketDoNotInterfere()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("       abcdefg! ["));
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("       abcdefg! ]"));
        }

        [TestMethod]
        public void StringWithoutBracketsReturnsTrue()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("Claire"));
        }

        [TestMethod]
        public void OneExtraBracketReturnsFalse()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("[[[]]]]"));
        }
    }
}
