namespace Interview.Algorithms
{
    public class ReverseArray
    {
        int[] nums;
        private int startIndex;
        private int endIndex;
        public ReverseArray(int[] nums)
        {
            this.nums = nums;
            startIndex = 0;
            endIndex = nums.Length - 1;
        }

        public int[] GetReverseArray()
        {
            while(endIndex > startIndex){
                int start = nums[startIndex];
                nums[startIndex] = nums[endIndex];
                nums[endIndex] = start;
                startIndex++;
                endIndex--;
            }
            return nums;
        }
    }
}