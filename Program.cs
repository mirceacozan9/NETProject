using System;

namespace NETProject
{
    class Program
    {
        static void Main(string[] args)
        {
            string dir = System.IO.Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName;
            string filepath = dir + @"\TestSHA1.txt";

            ConvertFileToString converter = new ConvertFileToString(filepath);
            string text = converter.GetText();

            SHA1Compute hash = new SHA1Compute(text);
            string final = hash.Hash();

            Console.WriteLine(final);
            Console.ReadKey();
        }
    }
}
