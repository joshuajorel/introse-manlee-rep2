using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;
using System.Text;
using System.Net.Mail;

namespace introseHHC.Objects
{
    public static class Checker
    {

        public static bool check(string input)
        {
            var pat = @"^[a-zA-Z'][a-zA-Z\s']*[a-zA-Z']?$";
            Match match = Regex.Match(input, pat, RegexOptions.IgnoreCase);

            if (input != string.Empty && match.Success)
                return true;
            else
                return false;
        }

        public static bool check2(string input2)
        {
            var pat2 = @"[0-9]*";
            Match match2 = Regex.Match(input2, pat2, RegexOptions.IgnoreCase);

            if (input2 != string.Empty && match2.Success)
                return true;
            else
                return false;
        }

        public static bool check3(string input3)
        {
            var pat3 = @"^[a-zA-Z0-9][a-zA-Z0-9\s\-.]*[a-zA-Z0-9']?$";
            Match match3 = Regex.Match(input3, pat3, RegexOptions.IgnoreCase);

            if (input3 != string.Empty && match3.Success)
                return true;
            else
                return false;
        }

        public static bool gend(string input3)
        {
            var patgen = @"(m|f)";
            Match mgen = Regex.Match(input3, patgen, RegexOptions.IgnoreCase);

            if (input3 != string.Empty && mgen.Success)
                return true;
            else
                return false;
        }

        public static bool email(string eadd)
        {
            try
            {
                MailAddress m = new MailAddress(eadd);
                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }
    }
}
