public class Solution {
    public int MaxArea(int[] heights) {
      List<int> area = new List<int>();
int left=0, right=heights.Length-1;
for (int i = 0; i < heights.Length; i++)
{
    if (right == left)
        break;
    else if (heights[left] <= heights[right])
    {
        area.Add(heights[left] * (right - left));
        left++;
    }
    else
    {
        area.Add(heights[right] * (right - left));
        right--;
    }
}
area.Sort();
return area.Max(x => x);  
    }
}
