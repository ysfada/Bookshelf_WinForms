using System;
using System.Security.Cryptography;
using System.Threading.Tasks;

namespace Bookshelf.Utilities
{
    internal static class Hash
    {
        private const int SaltSize = 24;
        private const int Iterations = 1000;

        public static string Create(string password)
        {
            var rfc2898DeriveBytes = new Rfc2898DeriveBytes(password, SaltSize, Iterations);

            var hash = rfc2898DeriveBytes.GetBytes(SaltSize);

            return $"{Convert.ToBase64String(rfc2898DeriveBytes.Salt)}|{rfc2898DeriveBytes.IterationCount}|{Convert.ToBase64String(hash)}";
        }

        public static async Task<string> CreateAsync(string password)
        {
            var rfc2898DeriveBytes = await Task.Run(() => new Rfc2898DeriveBytes(password, SaltSize, Iterations));

            var hash = rfc2898DeriveBytes.GetBytes(SaltSize);

            return $"{Convert.ToBase64String(rfc2898DeriveBytes.Salt)}|{rfc2898DeriveBytes.IterationCount}|{Convert.ToBase64String(hash)}";
        }

        public static bool Compare(string password, string hash)
        {
            var originalParts = hash.Split('|');
            var originalSalt = Convert.FromBase64String(originalParts[0]);
            var originalIterations = int.Parse(originalParts[1]);
            var originalHash = originalParts[2];

            var rfc2898DeriveBytes = new Rfc2898DeriveBytes(password, originalSalt, originalIterations);
            var newHash = rfc2898DeriveBytes.GetBytes(SaltSize);

            return Convert.ToBase64String(newHash) == originalHash;
        }

        public static async Task<bool> CompareAsync(string password, string hash)
        {
            var originalParts = hash.Split('|');
            var originalSalt = Convert.FromBase64String(originalParts[0]);
            var originalIterations = int.Parse(originalParts[1]);
            var originalHash = originalParts[2];

            var rfc2898DeriveBytes = await Task.Run(() => new Rfc2898DeriveBytes(password, originalSalt, originalIterations));
            var newHash = rfc2898DeriveBytes.GetBytes(SaltSize);

            return Convert.ToBase64String(newHash) == originalHash;
        }
    }
}
