using OHCE_Adeline_Martineau.Langues;
using OHCE_Adeline_Martineau;
using Xunit;

namespace OHCE.Test.xUnit
{
    public class LangueTest
    {
        [Theory]
        [InlineData(Expressions.Français.Bonjour)]
        public void testFrancais(string salutations)
        {
            ILangue francais = new Français();

            var bonjour = francais.direBonjour(PeriodeJournee.Matin);

            Assert.Equal(salutations, bonjour);

        }

        [Theory]
        [InlineData(Expressions.English.Bonjour)]
        public void testAnglais(string salutations)
        {
            ILangue anglais = new Anglais();

            var bonjour = anglais.direBonjour(PeriodeJournee.Matin);

            Assert.Equal(salutations, bonjour);

        }
    }
}
