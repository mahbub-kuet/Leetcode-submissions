public class Solution {
    public static bool IsPrime(int n)
    {
        bool isprime=true;
        for(int i=2;i*i<=n;i++)
        {
            if(n%i==0)
            {
                isprime=false;
                break;
            }
        }
        return isprime;
    }
    public int CountPrimes(int n) {
        int NoOfPrime=0;
        for(int i=2;i<n;i++)
        {
            if(IsPrime(i))
               NoOfPrime++;
        }
        return NoOfPrime;
    }
}