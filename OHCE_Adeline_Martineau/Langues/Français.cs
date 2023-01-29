using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OHCE_Adeline_Martineau.Langues
{
    public class Français: ILangue
    {
        public string BienDit => "Bien Dit !";
        public string direBonjour(PeriodeJournee periodeJournee)
        {
            return periodeJournee == PeriodeJournee.Matin ? Expressions.Français.Bonjour : Expressions.Français.Bonsoir;

        }
        public string AuRevoir => "Au revoir";
    }
}
