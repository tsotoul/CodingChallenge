using System;

namespace CodingChallenge.ReversingString
{
    public class StringUtilities
    {
        public static string Reverse(string s)
        {
            char[] result = new char[s.Length];

            for(int i = 0; i <= s.Length / 2; i++)
            {
                result[i] = s[s.Length - i - 1];
                result[s.Length - i - 1] = s[i];                
            }
            return new String(result);
            //return result.ToString() throws 'System char[]' in the console
        }
    }
}
