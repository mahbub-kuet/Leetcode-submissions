public class Solution {
    public IList<int> GrayCode(int n) {
    List<int> r = new List<int>();
    r.Add(0);int mask=0x1;
    for(int i=1; i<=n; i++)
    {
        int len=r.Count;
        for(int j=len-1; j>=0; j--)
        {
            int v=mask|r[j];
            r.Add(v);
        }

        mask=mask<<1;
    }

    return r;
    }
}