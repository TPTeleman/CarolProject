using System;
using System.Security.Cryptography;
using System.Text;

public static class PasswordHasher
{
    private const int SaltSize = 16;
    private const int KeySize = 32;
    private const int Iterations = 10000;

    public static string HashPassword(string password)
    {
        using (var algorithm = new Rfc2898DeriveBytes(password, SaltSize, Iterations, HashAlgorithmName.SHA256))
        {
            var salt = algorithm.Salt;
            var key = algorithm.GetBytes(KeySize);
            return $"{Convert.ToBase64String(salt)}.{Convert.ToBase64String(key)}";
        }
    }

    public static bool VerifyPassword(string password, string hashedPassword)
    {
        var parts = hashedPassword.Split('.');
        if (parts.Length != 2)
            return false;

        var salt = Convert.FromBase64String(parts[0]);
        var key = Convert.FromBase64String(parts[1]);

        using (var algorithm = new Rfc2898DeriveBytes(password, salt, Iterations, HashAlgorithmName.SHA256))
        {
            var keyToCheck = algorithm.GetBytes(KeySize);
            return FixedTimeEquals(key, keyToCheck);
        }
    }
    
    public static bool FixedTimeEquals(byte[] a, byte[] b)
    {
        if (a.Length != b.Length)
            return false;

        int result = 0;
        for (int i = 0; i < a.Length; i++)
        {
            result |= a[i] ^ b[i];
        }
        return result == 0;
    }
}
