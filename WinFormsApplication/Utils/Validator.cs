using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace WinFormsApplication.Utils
{
    internal static class Validator
    {
        internal static bool isSolidTextField(string text) => Regex.IsMatch(text, @"^[a-z]+\d*$");
        internal static bool isTextWithoutSpaces(string text) => Regex.IsMatch(text, @"^\S*$");
        internal static bool isTextPhoneNumber(string text) => Regex.IsMatch(text, @"^((\+7){1}|8{1})9\d{9}$");

    }
}
