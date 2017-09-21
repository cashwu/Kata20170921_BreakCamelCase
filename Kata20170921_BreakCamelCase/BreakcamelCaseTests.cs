using System;
using System.Collections.Generic;
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
            var upperCharIndex = str.Select((c, i) => char.IsUpper(c) ? i : 0).Where(i => i != 0).ToList();

            upperCharIndex.Add(str.Length);

            var skip = 0;
            var result = upperCharIndex.Select(idx =>
            {
                var r = string.Concat(str.Skip(skip).Take(idx - skip));
                skip = idx;
                return r;
            });

            return string.Join(" ", result);
        }
    }
}
