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
            int result = 0;
            int reminder = 0;
            int n = _n;

            while(n > 0)
            {
                reminder = n % 10;
                result = result * 10 + reminder;
                n = n / 10;
            }

            return result;
        }
    }
}
