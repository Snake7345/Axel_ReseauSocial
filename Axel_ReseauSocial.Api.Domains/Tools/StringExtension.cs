using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Axel_ReseauSocial.Api.Domains.Tools
{
    internal static class StringExtension
    {
        internal static byte[] Hash(this string? value)
        {
            if (value is null)
                return Array.Empty<byte>();

            // Génération du pré-salage
            byte[] salt = GenerateSalt();

            using (SHA512 sha512 = SHA512.Create())
            {
                // Concaténation du pré-salage avec la valeur
                byte[] valueBytes = Encoding.UTF8.GetBytes(value);
                byte[] saltedValueBytes = new byte[salt.Length + valueBytes.Length];
                Buffer.BlockCopy(salt, 0, saltedValueBytes, 0, salt.Length);
                Buffer.BlockCopy(valueBytes, 0, saltedValueBytes, salt.Length, valueBytes.Length);

                // Calcul du hachage
                byte[] hashedBytes = sha512.ComputeHash(saltedValueBytes);
                return hashedBytes;
            }
        }

        private static byte[] GenerateSalt()
        {
            const int saltSize = 16; // Taille du pré-salage en octets

            using (RandomNumberGenerator rng = RandomNumberGenerator.Create())
            {
                byte[] salt = new byte[saltSize];
                rng.GetBytes(salt);
                return salt;
            }
        }

    }
}
