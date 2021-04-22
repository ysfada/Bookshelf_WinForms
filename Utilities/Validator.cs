using System.Linq;

namespace Bookshelf.Utilities
{
    internal static class Validator
    {
        public static bool IsLetter(char chr, string allowedChars = null) =>
            char.IsLetter(chr) || char.IsControl(chr) || InAllowed(chr, allowedChars);

        public static bool IsDigit(char chr, string allowedChars = null) =>
            char.IsDigit(chr) || char.IsControl(chr) || InAllowed(chr, allowedChars);

        public static bool InAllowed(char chr, string allowedChars) =>
            allowedChars != null && allowedChars.Any(allowedChar => chr == allowedChar);
    }
}
