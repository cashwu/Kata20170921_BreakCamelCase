using System;
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
            return str;
        }
    }
}
