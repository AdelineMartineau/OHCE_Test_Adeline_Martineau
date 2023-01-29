using OHCE_Adeline_Martineau;
using System.Text;

var ohce = new Ohce(new SystemLangProxy(), new SystemTimePeriodJourneeAdapter().PeriodeJournee);

Console.WriteLine(new SystemTimePeriodJourneeAdapter().PeriodeJournee);

Console.WriteLine(ohce.Saluer());

Console.WriteLine(ohce.palindrome(Console.ReadLine() ?? String.Empty));

Console.WriteLine(ohce.AuRevoir());