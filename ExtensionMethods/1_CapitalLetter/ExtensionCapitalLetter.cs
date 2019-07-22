using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace _1_CapitalLetter
{
    public static class ExtensionCapitalLetter
    {
        public static bool CapitalLetter(this string str)
        {
            if (char.IsUpper(str[0]))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
