using OHCE_Adeline_Martineau.Langues;
using System.Text;

namespace OHCE_Adeline_Martineau
{
    public class Ohce
    {
        private ILangue _langue;
        private PeriodeJournee _periodeJournee;

        public Ohce(ILangue langue, PeriodeJournee periodeJournee)
        {
            _langue = langue;
            _periodeJournee = periodeJournee;
        }

        public string palindrome(string str)
        {
            StringBuilder stringBuilder = new StringBuilder();

            var reversed = new string(str.Reverse().ToArray());

            stringBuilder.Append(reversed);

            if (str == reversed)
            {
                stringBuilder.Append(_langue.BienDit);
            }

            return stringBuilder.ToString();
        }
        public ILangue getLangue()
        {
            return _langue;
        }
    }
}
