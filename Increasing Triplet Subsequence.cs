public class Solution {
    public bool IncreasingTriplet(int[] nums)
        {
            int size = nums.Length;
            if(size < 3)
               return false;

            int left= int.MaxValue,mid=int.MaxValue;


            for (int i = 0; i < size; i++)
            {
                if (nums[i] > mid)
                    return true;
                else if (nums[i] > left && nums[i] < mid)
                    mid = nums[i];
                else if (nums[i] < left)
                    left = nums[i];
            }
                return false;
        }
}