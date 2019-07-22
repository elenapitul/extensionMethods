using System;
using System.Collections.Generic;
using System.Text;

namespace _5_CharacterCount
{
    public static class ExtensionCharacterCount
    {
        public static int CharacterCount(this string str)
        {
            int count = 0;

            foreach (char item in str)
            {
                count++;
            }

            return count;
        }
    }
}
