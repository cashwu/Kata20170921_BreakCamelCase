using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Kata20170921_BreakCamelCase
{
    [TestClass]
    public class BreakcamelCaseTests
    {
        [TestMethod]
        public void input_abc_should_return_abc()
        {
            BreakCamelCaseShouldBe("abc", "abc");
        }

        [TestMethod]
        public void input_abcAbc_should_return_abcAbc()
        {
            BreakCamelCaseShouldBe("abc Abc", "abcAbc");
        }

        [TestMethod]
        public void input_abcAbcAbc_should_return_abcAbc()
        {
            BreakCamelCaseShouldBe("abc Abc Abc", "abcAbcAbc");
        }

        private static void BreakCamelCaseShouldBe(string expected, string str)
        {
            var kata = new Kata();
            var actual = kata.BreakCamelCase(str);
            Assert.AreEqual(expected, actual);
        }
    }

    public class Kata
    {
        public string BreakCamelCase(string str)
        {
            return string.Concat(str.Select(c => char.IsUpper(c) ? " " + c : c.ToString()));
        }
    }
}
