﻿using System.Linq;

namespace NSE.Core.Utils
{
    public static class StringUtils
    {
        public static string ApenasNumeros(this string _, string input)
        {
            return new string(input.Where(char.IsDigit).ToArray());
        }
    }
}
