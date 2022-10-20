using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmProgram
{
    public class Anagram
    {
        public void CheckAnagram()
        {
            string str1 = "cat";
            string str2 = "act";

            char[] ch1 = str1.ToLower().ToCharArray();
            char[] ch2 = str2.ToLower().ToCharArray();

            Array.Sort(ch1);
            Array.Sort(ch2);
            string vall1 = new string(ch1);
            string vall2 = new string(ch2);

            Console.WriteLine(vall1);
            Console.WriteLine(vall2);

            if (vall1 == vall2)
            {
                Console.WriteLine("Anagram");
            }
            else
            {
                Console.WriteLine("Not Anagram");
            }
        }
    }
}