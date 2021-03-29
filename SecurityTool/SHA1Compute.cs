using System;
using System.Text;
using System.Security.Cryptography;

namespace NETProject
{
    public class SHA1Compute
    {

        public SHA1Compute(string source)
        {
            Source = source;
        }

        public string Source { get; }

        public string Hash()
        {
            using (SHA1 sha1Hash = SHA1.Create())
            {
                byte[] sourceBytes = Encoding.UTF8.GetBytes(Source);
                byte[] hashBytes = sha1Hash.ComputeHash(sourceBytes);
                string hashFinal = BitConverter.ToString(hashBytes).Replace("-", String.Empty);
                return FormatHash(hashFinal);
            }
        }

        public string FormatHash(string hash)
        {
            for (int i = 4; i <= hash.Length; i += 4)
            {
                hash = hash.Insert(i, "-");
                i++;
            }
            hash = hash.Remove(hash.Length - 1);
            return hash;
        }

    }
}
