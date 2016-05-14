public class Solution {
    public int HammingWeight(uint n) {
         string a = Convert.ToString(n,2);
            int hammingweight = 0;
            foreach(char c in a)
            {
                if (c == '1')
                {
                    hammingweight++;
                }
            }
            return hammingweight;
        
    }
}