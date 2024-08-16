public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int x = 1, y = 1;
        int[] result = new int[nums.Length];        
        
        for(int i = 0; i < nums.Length; i++){
            result[i] = x;
            x *= nums[i];             
        }
        
        for(int i = nums.Length-1; i>=0; i--){
            result[i] *= y;
            y *= nums[i];          
        }
        return result;
        
    }
}