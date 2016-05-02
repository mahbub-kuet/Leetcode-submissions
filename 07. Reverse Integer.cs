public class Solution {
    public int Reverse(int x) {
        try
            {
                if (x < 0)
                {
                    x = -x;
                    string s = x.ToString();
                    char[] c = s.ToCharArray();
                    Array.Reverse(c);
                    s = new string(c);
                    return Convert.ToInt32(s) * -1;
                }
                else
                {
                    string s = x.ToString();
                    char[] c = s.ToCharArray();
                    Array.Reverse(c);
                    s = new string(c);
                    return Convert.ToInt32(s);
                }
            }
            catch {
                return 0;
            }
    }
}