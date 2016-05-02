public class Solution {
    public int[] SearchRange(int[] nums, int target) {
        int index = Array.BinarySearch(nums,target);
            int upperIndex = 0, loweIndex = 0;
            if(index<0)
            {
                //upperIndex = -1;
               // loweIndex = -1;
               int[] res={-1,-1};
               return res;
            }
            else
            {
                upperIndex = index;
                loweIndex = index;
                while(true)
                {
                    if (index == 0)
                        break;
                    index--;
                    if (nums[index] == target)
                        loweIndex = index;
                    else
                        break;

                }
                while (true)
                {
                    if (index == nums.Length-1)
                        break;
                    index++;
                    if (nums[index] == target)
                        upperIndex = index;
                    else
                        break;

                }
                int[] res={loweIndex,upperIndex};
               return res;
        
    }
    }
}