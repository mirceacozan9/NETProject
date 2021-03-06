using System;
using System.Collections.Generic;
using System.Text;
using System.Security.Cryptography;
using System.IO;

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
                return hashFinal;
            }
        }
    }

    public class ConvertFileToString
    {

        public ConvertFileToString(string filepath)
        {
            Filepath = filepath;
        }
    public string Filepath { get; }
    
    public string GetText()
        {
            string txt = System.IO.File.ReadAllText(Filepath);
            return txt;
        }
    }
}
