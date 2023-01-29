using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OHCE_Adeline_Martineau.Langues
{
    public interface ILangue
    {
        string BienDit { get; }
        string direBonjour(PeriodeJournee periodeJournee);
        string AuRevoir { get; }
    }
}
