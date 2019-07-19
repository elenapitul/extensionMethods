using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace _3_CapitalizeWord
{
    public static class ExtensionCapitalize
    {
        public static string Capitalize (this string str)
        {
            return str.ToUpper(); 
        }
    }
}
