using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.MasterOfCodingInterview.Algorithms
{
    public class MergeSort 
    {

        public void MergeSrt(int[] num)
        {
            if (num.Length == 1)
            {
                return;
            }

            int middleIndex = num.Length / 2;
            int[] leftHalf = new int[middleIndex];
            int[] righttHalf = new int[num.Length - middleIndex];

            MergeSrt(leftHalf);
            MergeSrt(righttHalf);

            int i = 0, j = 0, k = 0;

            while (i < leftHalf.Length && j < righttHalf.Length)
            {
                if (leftHalf[i] < righttHalf[j])
                {
                    num[k] = leftHalf[i];
                    i++;
                }
                else
                {
                    num[k] = righttHalf[j];
                    j++;
                }
                k++;
            }

            while (i < leftHalf.Length)
            {
                num[k] = leftHalf[i];
                i++;
                k++;
            }
            while (j < righttHalf.Length)
            {
                num[k] = righttHalf[j];
                j++;
                k++;
            }
        }
    }
}
