using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XtEpamTask04_5
{
    public static class StringExtension
    {
        public static bool IsNumber(this string number)
        {
            foreach (char symbol in number)
                if (!char.IsDigit(symbol))
                    return false;
            return true;
        }
    }
}
