using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OHCE_Adeline_Martineau;
using OHCE_Adeline_Martineau.Langues;
using Xunit;

namespace OHCE.Test.xUnit
{
    public class PalindromeTests
    {
        [Fact]
        public void reverseTest()
        {
            Ohce ohce = new Ohce();

            var sortie = ohce.palindrome("yolo");

            Assert.Equal("oloy", sortie);
        }

        [Fact]
        public void palindromeTest()
        {
            Ohce ohce = new Ohce();

            var sortie = ohce.palindrome("kayak");
            string palindrome = "kayak";

            Assert.Contains(palindrome + " Bien dit !", sortie);
        }
    }
}
