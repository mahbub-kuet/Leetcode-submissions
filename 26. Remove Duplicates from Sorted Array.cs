public class Solution {
    public int RemoveDuplicates(int[] nums) {
        int len = nums.Length;
        if (len < 2) return len;
        int offset = 0;
        int i = 0;
        while (i + offset < len)
        {
            nums[i] = nums[i + offset];
            if (i + offset + 1 < len)
                if (nums[i] == nums[i + offset + 1])
                    offset++;
                else
                    i++;
            else
                break;
        }
        return len - offset;
        
    }
}