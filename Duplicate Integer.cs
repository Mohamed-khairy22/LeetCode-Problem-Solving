public class Solution {
    public bool ContainsDuplicate(int[] nums) {
        List<int> list = new List<int>();
            foreach (int x in nums){
                if (list.Contains(x))
                    return true;
                list.Add(x);
            }
        return false;
    }
}