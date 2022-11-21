using System.Text.RegularExpressions;

namespace WinFormsApplication.Utils
{
    internal static class Validator
    {
        internal static bool isUserName(string text) => Regex.IsMatch(text, @"^[a-z]+\d*$");
        internal static bool isTextWithoutSpaces(string text) => Regex.IsMatch(text, @"^\S*$");
        internal static bool isTextPhoneNumber(string text) => Regex.IsMatch(text, @"^((\+?7){1}|8{1})9\d{9}$");
        internal static bool isTextBeginsWithSpaceOrEmpty(string text) => Regex.IsMatch(text, @"^\s+") || text.Equals("");
    }
}