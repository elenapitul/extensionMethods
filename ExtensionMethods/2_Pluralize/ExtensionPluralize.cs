using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace _2_Pluralize
{
    public static class ExtensionPluralize
    {
        public static StringBuilder Pluralize(this StringBuilder str)
        { 
            return str.Append("s");
        }
    }
}
