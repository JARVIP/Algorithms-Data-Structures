namespace Algorithms.Codility
{
    public class MinAvgTwoSlice
    {
        private int[] _a;

        public MinAvgTwoSlice(int[] a)
        {
            _a = a;
        }

        public int Solution()
        {
            int minAvgIndex = 0;
            double minAvg = double.MaxValue;

            for (int i = 0; i < _a.Length; i++)
            {
                double sum = _a[i];
                for (int j = i + 1; j < _a.Length; j++)
                {
                    sum += (double)_a[j];

                    double avg = (double)sum / (double)(j - i + 1);
                    if (avg < minAvg)
                    {
                        minAvg = avg;
                        minAvgIndex = i;
                    }
                    else if (j - i > 1)
                    {
                        break;
                    }
                }
            }
            return minAvgIndex;
        }

    }
}
