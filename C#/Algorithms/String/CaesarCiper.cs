using System;

namespace Algorithms.String
{
    /*
     * Julius Caesar protected his confidential information by encrypting it using a cipher.
     * Caesar's cipher shifts each letter by a number of letters.
     * If the shift takes you past the end of the alphabet, just rotate back to the front of the alphabet.
     * In the case of a rotation by 3, w, x, y and z would map to z, a, b and c.
        *  Original alphabet:      abcdefghijklmnopqrstuvwxyz
        *  Alphabet rotated +3:    defghijklmnopqrstuvwxyzabc
     */
    public class CaesarCiper
    {
        private string s;
        private int k;
        public CaesarCiper(string s, int k)
        {
            this.s = s;
            this.k = k;
        }
        public string Solve()
        {
            k = k % 26;
            char[] ch = s.ToCharArray();
            Console.WriteLine((122 + 27) % 122);
            for (int i = 0; i < ch.Length; i++)
            {
                int res = 0;
                if (ch[i] > 64 && ch[i] < 91)
                {
                    res = (ch[i] + k) % 91;
                    res = res < 65 ? res + 65 : res;
                }
                if (ch[i] > 96 && ch[i] < 123)
                {
                    res = (ch[i] + k) % 123;
                    res = res < 97 ? res + 97 : res;
                }
                if (res != 0)
                    ch[i] = (char)(res);
            }
            return new string(ch);
        }
    }
}
