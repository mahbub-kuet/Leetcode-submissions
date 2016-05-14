public class Solution {
    
    public static int countDigitOne(int n)
        {
            if (n <= 0)
                return 0;


            int j = 1;
            int k = n;
            int constant = 0;
            while (k >= 10)
            {
                k = k / 10;
                j = j * 10;
            }
            if (k > 1)
            {
                constant = j;
            }
            else
            {
                constant = n % j + 1;
            }
            return constant + k * countDigitOne(j - 1) + countDigitOne(n % j);
        }
    public int CountDigitOne(int n) {
        return countDigitOne(n);
    }
}