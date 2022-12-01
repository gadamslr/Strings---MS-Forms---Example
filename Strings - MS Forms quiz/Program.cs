using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings___MS_Forms_quiz
{
    internal class Program
    {
        static string Replace(string S1, string S2, string S3)
        {
            int S = S1.IndexOf(S2);

            int E = S + S2.Length;

            string NewString = S1.Substring(0, S);

            NewString += S3;

            NewString += S1.Substring(E, S1.Length - E);

            return NewString;
        }

        static void Main(string[] args)
        {
         
            string Phrase = "Strings are the root of physics.";

            string Word1 = "are";


            string Word2 = "may be";
            
            Console.WriteLine(Replace(Phrase, Word1, Word2));

        }
    }
}
