public class Solution {
    public void SortColors(int[] nums) {
        int index0 = -1, index1 = -1, index2 = -1;
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] == 2)
                index2 = index2 != -1 ? index2 + 1 : index1 != -1 ? index1 + 1 : index0 != -1 ? index0 + 1 : 0;
            else if (nums[i] == 1)
            {
                index2 = index2 == -1 ? -1 : index2 + 1;
                index1 = index1 != -1 ? index1 + 1 : index0 != -1 ? index0 + 1 : 0;
                nums[index1] = 1;
                if (index2 != -1) nums[index2] = 2;
            }
            else if (nums[i] == 0)
            {
                index2 = index2 == -1 ? -1 : index2 + 1;
                index1 = index1 != -1 ? index1 + 1 : -1;
                index0++;
                nums[index0] = 0;
                if (index1 != -1) nums[index1] = 1;
                if (index2 != -1) nums[index2] = 2;
            }
        }
    }
}