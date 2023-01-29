using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OHCE_Adeline_Martineau.Langues
{
    public class Anglais: ILangue
    {
        public string BienDit => "Well said";
        public string direBonjour(PeriodeJournee periodeJournee)
        {
            return periodeJournee == PeriodeJournee.Matin ? Expressions.English.Bonjour : Expressions.English.Bonsoir;
        }
        public string AuRevoir => "Good bye";
    }
}
