public class Solution {
    public IList<int> MajorityElement(int[] nums) {
        List<int> list = new List<int>();
            Array.Sort(nums);
            int a =nums.Length/3;
            for (int i = 0; i < (nums.Length-a);i++ )
            {
                if(nums[i]==nums[i+a])
                {
                    list.Add(nums[i]);
                    i = i + a;
                }
            }
            
            return list.Distinct().ToList();
        
    }
}