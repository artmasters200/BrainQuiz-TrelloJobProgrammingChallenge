using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrelloJobProgrammingChallenge
{
    class Program
    {
        private static long hash(string s)
        {
            long h = 7;
            string letters = "acdegilmnoprstuw";
            for (int i = 0; i < s.Length; i++)
            {
                //Console.WriteLine("h:" + h + " i:" + i + " s[i]:" + s[i] + " lettersIndex:" + letters.IndexOf(s[i]));
                h = h * 37 + letters.IndexOf(s[i]);
            }
            return h;
        }

        private static string unhash(long hashnumber, string secretword = "")
        {
            long h = 7;
            string letters = "acdegilmnoprstuw";

            var a = hashnumber / 37;
            var b = hashnumber % 37;

            //Console.WriteLine(letters[(int) b]);
            secretword = letters[(int)b] + secretword;

            //Debug.WriteLine(a + " " + b);
            if (a == h)
                return secretword;

            return unhash(a, secretword);
        }


        static void Main(string[] args)
        {
            var hashresult = hash("leepadg");
            var unhashresult = unhash(hashresult);

            long number = 956446786872726;
            unhashresult = unhash(number);
        }
}
}
