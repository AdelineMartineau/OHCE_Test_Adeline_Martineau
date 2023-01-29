using OHCE_Adeline_Martineau;
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
