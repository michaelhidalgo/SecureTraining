using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegEx
{
    public class RegularExpressions
    {
        public static bool  Match (string input, string patern)
        {
            return System.Text.RegularExpressions.Regex.IsMatch(input, patern);
        }
    }
}
