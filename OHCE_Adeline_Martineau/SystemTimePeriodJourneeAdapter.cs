using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OHCE_Adeline_Martineau
{
    public class SystemTimePeriodJourneeAdapter
    {
        public SystemTimePeriodJourneeAdapter()
        {

        }
        public PeriodeJournee PeriodeJournee
        {
            get
            {
                if (DateTime.Now.Hour > 6 && DateTime.Now.Hour < 12)
                {
                    return PeriodeJournee.Matin;
                }
                else if (DateTime.Now.Hour > 12 && DateTime.Now.Hour < 17)
                {
                    return PeriodeJournee.ApresMidi;
                }
                else if (DateTime.Now.Hour > 17 && DateTime.Now.Hour < 20)
                {
                    return PeriodeJournee.Soir;
                }
                else
                {
                    return PeriodeJournee.Nuit;
                }
            }
        }
    }
}
