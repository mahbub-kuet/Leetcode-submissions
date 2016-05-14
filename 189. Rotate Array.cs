public class Solution {
    public void Rotate(int[] nums, int k) {
         for (int i = 0; i < k; i++)
            {
                int last = nums[nums.Length - 1];
                Array.Copy(nums, 0, nums, 1, nums.Length - 1);
                nums[0] = last;
            
            }
    }
}