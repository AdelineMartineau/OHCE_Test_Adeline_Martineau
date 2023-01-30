using OHCE_Adeline_Martineau.Langues;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OHCE_Adeline_Martineau
{
    public class SystemLangProxy :ILangue
    {
        public string BienDit => System.Globalization.CultureInfo.CurrentCulture.ToString() == "fr-FR" ? Expressions.Français.BienDit : (System.Globalization.CultureInfo.CurrentCulture.ToString() == "en-EN" ? Expressions.English.BienDit : "");

        public string AuRevoir => System.Globalization.CultureInfo.CurrentCulture.ToString() == "fr-FR" ? Expressions.Français.AuRevoir : (System.Globalization.CultureInfo.CurrentCulture.ToString() == "en-EN" ? Expressions.English.AuRevoir : "");

        public string direBonjour(PeriodeJournee periode)
        {
            if (System.Globalization.CultureInfo.CurrentCulture.ToString() == "fr-FR")
            {
                switch (periode)
                {
                    case PeriodeJournee.Matin:
                        return Expressions.Français.Bonjour;
                    case PeriodeJournee.ApresMidi:
                        return Expressions.Français.Bonjour;
                    case PeriodeJournee.Soir:
                        return Expressions.Français.Bonsoir;
                    case PeriodeJournee.Nuit:
                        return Expressions.Français.BonneNuit;
                    default:
                        return Expressions.Français.Bonjour;
                }
            }
            else if (System.Globalization.CultureInfo.CurrentCulture.ToString() == "en-EN")
            {
                switch (periode)
                {
                    case PeriodeJournee.Matin:
                        return Expressions.English.Bonjour;
                    case PeriodeJournee.ApresMidi:
                        return Expressions.English.Bonjour;
                    case PeriodeJournee.Soir:
                        return Expressions.English.Bonsoir;
                    case PeriodeJournee.Nuit:
                        return Expressions.English.BonneNuit;
                    default:
                        return Expressions.English.Bonjour;
                }
            }
            else {
                return "Langue ou période système introuvable";
            }
        }
    }
}
