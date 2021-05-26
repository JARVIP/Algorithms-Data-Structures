namespace Interview.Algorithms
{
    public class PalindromeCheck
    {
        private string _s;

        public PalindromeCheck(string s)
        {
            _s = s;
        }

        public bool IsPalindrome()
        {
            for (int i = 0, j = _s.Length - 1; i < _s.Length && j > 0; i++, j--)
            {
                if(_s[i] != _s[j])
                {
                    return false;
                }
            }
            return true;
        }
    }
}
