using System;

namespace Contains
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = "O segredo é ter fé em Deus.";
            string s2 = "a";
            string s3 = "t";

            Console.WriteLine(":{0} ", s1.Contains(s2));

            Console.WriteLine(":{0} ", s1.Contains(s3));
        }
    }
}
