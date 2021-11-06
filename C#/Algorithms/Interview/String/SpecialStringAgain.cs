using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Interview.String
{
    public class SpecialStringAgain
    {
        public long Solve(int n,string str)
        {
            long result = 0L;
            int[] sameChar = new int[n];

            int i = 0;
            // traverse string character 
            // from left to right 
            while (i < n)
            {
                // store same character count 
                int sameCharCount = 1;
                int j = i + 1;
                // count smiler character 
                while (j < n && str[i] == str[j])
                {
                    sameCharCount++;
                    j++;
                }
                // Case : 1 
                // so total number of  
                // substring that we can 
                // generate are : K *( K + 1 ) / 2 
                // here K is sameCharCount 
                result += (sameCharCount *
                          (sameCharCount + 1) / 2);

                // store current same char  
                // count in sameChar[] array 
                sameChar[i] = sameCharCount;
                // increment i 
                i = j;
            }

            // Case 2: Count all odd length 
            //         Special Palindromic 
            //         substring 
            for (int j = 1; j < n; j++)
            {
                // if current character is  
                // equal to previous one  
                // then we assign Previous  
                // same character count to 
                // current one 
                if (str[j] == str[j - 1])
                    sameChar[j] = sameChar[j - 1];
                // case 2: odd length 
                if (j > 0 && j < (n - 1) && (str[j - 1] == str[j + 1] && str[j] != str[j - 1]))
                    result += Math.Min(sameChar[j - 1],
                                     sameChar[j + 1]);
            }
            return result;
        }
    }
}
