using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OHCE_Adeline_Martineau
{
    public class Ohce
    {
        public string palindrome(string str)
        {
            StringBuilder stringBuilder = new StringBuilder();

            var reversed = new string(str.Reverse().ToArray());

            stringBuilder.Append(reversed);

            if (str == reversed)
            {
                stringBuilder.Append(" Bien dit !");
            }

            return stringBuilder.ToString();
        }
    }
}
