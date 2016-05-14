public class Solution {
    public bool ContainsDuplicate(int[] nums) {
        
         Dictionary <int,bool> dic= new Dictionary<int,bool>();
            foreach (int i in nums)
            {
                if(!dic.ContainsKey(i))
                    dic.Add(i,true);
                 else 
                   return true;
            }
            
            return false;
        
    }
}