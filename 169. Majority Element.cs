public class Solution {
    public int MajorityElement(int[] nums) {
        Array.Sort(nums);
            int a =nums.Length/2;
            for (int i = 0; i < (nums.Length-a);i++ )
            {
                if(nums[i]==nums[i+a])
                {
                    return nums[i];
                }
            }
            
            return -1;
    }
}