namespace Algorithms.Codility
{
    public class PassingCars
    {
        private int[] _a;

        public PassingCars(int[] a)
        {
            _a = a;
        }

        public int Solution()
        {
            int count = 0;
            int[] prefix = new int[_a.Length + 1];
            for (int i = 1; i < prefix.Length; i++)
            {
                prefix[i] = prefix[i - 1] + _a[i - 1];
            }

            for (int i = 0; i < _a.Length; i++)
            {
                if (_a[i] == 0)
                {
                    count += prefix[prefix.Length - 1] - prefix[i];
                    if (count >= 1000000000)
                    {
                        return -1;
                    }
                }
            }
            return count;
        }
    }
}
