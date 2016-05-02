public class Solution {
    public double MyPow(double x, int n) {
        double result=1;
        bool isnegative=false;
        if(n==0)
           return 1;
        if(n<0)
        {
            n=n*-1;
            isnegative=true;
        }
        for (; n>0; )
                {
                    if (n % 2 == 0)
                    {
                        x = x * x;
                        n = n / 2;
                    }
                    result = result * x;
                    n--;
                }
        if(isnegative)
            return 1/result;
        else           
            return result;
    }
}