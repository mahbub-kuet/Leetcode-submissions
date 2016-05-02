public class Solution {
    public bool IsPalindrome(int x) {
         int b = 0;
            int a = x;
            while (a > 0)
            {
                b = b * 10 + (a%10);
                a = a / 10;            
            }
            if (x == b)
                return true;
            else
                return false;
        
    }
}