using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace StockApp.Utils.Extensions
{
    public static class StringExtensions
    {
        public static string ToSlug(this string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return input;
            }


            input = input.ToLower();

            input = input
                .Replace("ı", "i")
                .Replace("ş", "s")
                .Replace("ğ", "g")
                .Replace("ç", "c")
                .Replace("ü", "u")
                .Replace("ö", "o");

            input = Regex.Replace(input, @"[^a-zA-Z0-9-]", "-");
            input = Regex.Replace(input, @"[-]+", "-");
            input = input.Trim('-');

            return input;
        }
    }
}
