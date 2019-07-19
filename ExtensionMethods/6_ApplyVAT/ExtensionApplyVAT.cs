using System;
using System.Collections.Generic;
using System.Text;

namespace _6_ApplyVAT
{
    public static class ExtensionApplyVAT
    {
        public static decimal ApplyVAT(this decimal number)
        {
            return number * 1.24m;
        }
    }
}
