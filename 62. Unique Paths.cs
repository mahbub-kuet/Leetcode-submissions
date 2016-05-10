public class Solution {
    
   public static int row = 0, col = 0;
   static int[,] dp= new int[101,101];       
        
        
        public static int uniquepath(int a, int b)
        {
            if (dp[a, b] != -1)
                return dp[a, b];
            else
            {
                if (a == row && b == col)
                {
                    return 1;
                }
                else if (a == row && b != col)
                {
                    dp[a, b] = uniquepath(a, b+1);
                    return dp[a, b];
                }
                else if (b == col && a != row)
                {
                    dp[a, b] = uniquepath(a + 1, b);
                    return dp[a, b];
                }
                else
                {
                    dp[a, b] = uniquepath(a + 1, b) + uniquepath(a, b + 1);
                    return dp[a,b];
                }
            }


        }
    public int UniquePaths(int m, int n)
    {
         row=m; col=n;
         for (int i = 0; i < 101; i++)
            {
                for (int j = 0; j < 101; j++)
                {
                    dp[i, j] = -1;
                }
            }
        int UniquePath=uniquepath(1,1);
        
        return UniquePath;
    }
}