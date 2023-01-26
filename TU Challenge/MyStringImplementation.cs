using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TU_Challenge
{
    public class MyStringImplementation
    {
        public static string BazardString(string input)
        {
            throw new NotImplementedException();
        }

        public static bool IsNullEmptyOrWhiteSpace(string input)
        {
            return string.IsNullOrWhiteSpace(input);
        }

        public static string MixString(string a, string b)
        {
            string result = "";

            int minLength = Math.Min(a.Length, b.Length);
            for (int i = 0; i < minLength; i++)
            {
                result += a[i];
                result += b[i];
            }

            if (a.Length > minLength)
            {
                result += a.Substring(minLength);
            }
            else if (b.Length > minLength)
            {
                result += b.Substring(minLength);
            }

            return result;
        }

        public static string Reverse(string a)
        {
            char[] inputArray = a.ToCharArray();
            Array.Reverse(inputArray);
            string reversed = new string(inputArray);

            return reversed;
        }

        public static string ToCesarCode(string input, int offset)
        {
            throw new NotImplementedException();
        }

        public static string ToLowerCase(string a)
        {
            char[] inputChars = a.ToCharArray();
            for (int i = 0; i < inputChars.Length; i++)
            {
                inputChars[i] = char.ToLower(inputChars[i]);
            }
            string lowerCase = new string(inputChars);

            return lowerCase;
        }

        public static string UnBazardString(string input)
        {
            throw new NotImplementedException();
        }

        public static string Voyelles(string a)
        {

            string voyelles = "";

            foreach (char c in a)
            {
                if ((c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u' || c == 'y' || c == 'A' || c == 'E' || c == 'I' || c == 'O' || c == 'U' || c == 'Y') && !voyelles.Contains(c))
                {
                    voyelles += c;
                }
            }

            char[] inputChars = voyelles.ToCharArray();
            for (int i = 0; i < inputChars.Length; i++)
            {
                inputChars[i] = char.ToLower(inputChars[i]);
            }
            string lowerCaseVoyelles = new string(inputChars);

            return lowerCaseVoyelles;
        }
    }
}
