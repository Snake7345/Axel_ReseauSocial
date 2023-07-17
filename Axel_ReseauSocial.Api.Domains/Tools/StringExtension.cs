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
            byte[] salt = new byte[] { 0x7B, 0xE1, 0x42, 0x9C, 0x83, 0x2F, 0xA0, 0xC6, 0x19, 0xD4, 0x1F, 0xB8, 0xE7, 0x7A, 0x3C, 0x6D };

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

    }
}
