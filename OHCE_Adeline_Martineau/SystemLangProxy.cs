using OHCE_Adeline_Martineau.Langues;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OHCE_Adeline_Martineau
{
    internal class SystemLangProxy :ILangue
    {
        public string BienDit => System.Globalization.CultureInfo.CurrentCulture.ToString() == "fr-FR" ? Expressions.Français.BienDit : (System.Globalization.CultureInfo.CurrentCulture.ToString() == "en-EN" ? Expressions.English.BienDit : "");

        public string AuRevoir => System.Globalization.CultureInfo.CurrentCulture.ToString() == "fr-FR" ? Expressions.Français.AuRevoir : (System.Globalization.CultureInfo.CurrentCulture.ToString() == "en-EN" ? Expressions.English.AuRevoir : "");

        public string direBonjour(PeriodeJournee période)
        {
            if (System.Globalization.CultureInfo.CurrentCulture.ToString() == "fr-FR")
            {
                return période == PeriodeJournee.Soir
                    ? Expressions.Français.Bonsoir
                    : Expressions.Français.Bonjour;
            }
            else if (System.Globalization.CultureInfo.CurrentCulture.ToString() == "en-EN")
            {
                return période == PeriodeJournee.Soir
                    ? Expressions.English.Bonsoir
                    : Expressions.English.Bonjour;
            }
            else
            {
                return "";
            }
        }
    }
}
