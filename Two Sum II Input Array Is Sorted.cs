public class Solution {
     public int[] TwoSum(int[] numbers, int target)
 {
     int[] result = new int[2];
     int start=0, end=numbers.Length-1;
     for (int i=0; i<numbers.Length; i++)
     {
         if (numbers[start] + numbers[end] < target)
             start++;
         else if (numbers[start] + numbers[end] > target)
             end--;
         else
         {
             result[0] = start + 1;
             result[1] =end+1;
             break;
         }
     }
     return result;
 }
}
