namespace Interview.Algorithms
{
    public class ReverseInteger
    {
        public int _n;

        public ReverseInteger(int n)
        {
            _n = n;
        }

        public int Reverse()
        {
            //int result = 0;
            //int reminder = 0;
            //int n = _n;

            //while(n > 0)
            //{
            //    reminder = n % 10;
            //    result = result * 10 + reminder;
            //    n = n / 10;
            //}

            //return result;

            int result = 0;
            int reminder = 0;
            int n = _n;
            int nZero = _n;

            int zeroCount = 0;

            while (nZero % 10 == 0)
            {
                zeroCount++;
                nZero = nZero / 10;
            }
            while (n > 0)
            {
                reminder = n % 10;
                result = result * 10 + reminder;
                n = n / 10;
            }
            for (int i = 0; i < zeroCount; i++)
            {
                result *= 10;
            }

            return result;
        }
    }
}
