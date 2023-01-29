using OHCE_Adeline_Martineau;
using OHCE_Adeline_Martineau.Langues;
using Xunit;

namespace OHCE.Test.xUnit
{
    public class OhceTest
    {
        [Fact]
        public void reverseTest()
        {
            Ohce ohce = new Ohce(null, PeriodeJournee.Soir);

            var sortie = ohce.palindrome("yolo");

            Assert.Equal("oloy", sortie);
        }

        [Fact]
        public void palindromeTest()
        {
            Ohce ohce = new Ohce(new SystemLangProxy(), PeriodeJournee.Soir);

            var sortie = ohce.palindrome("kayak");
            string palindrome = "kayak";

            Assert.Contains(palindrome + ohce.getLangue().BienDit, sortie);
        }
    }
}
