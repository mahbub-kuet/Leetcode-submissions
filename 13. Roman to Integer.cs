public class Solution {
    public int RomanToInt(string s) {
        s = s.ToLower() + " ";
            int Int = 0;
            while(s.Length>1)
            {
                if(s[0]=='c' && s[1]=='m')
                {
                    Int += 900;
                    s = s.Substring(2, s.Length - 2);
                }
                else if(s[0]=='m')
                {
                    Int += 1000;
                    s = s.Substring(1, s.Length - 1);
                }
                else if (s[0] == 'c' && s[1] == 'd')
                {
                    Int += 400;
                    s = s.Substring(2, s.Length - 2);
                }
                else if (s[0] == 'd')
                {
                    Int += 500;
                    s = s.Substring(1, s.Length - 1);
                }
                else if (s[0] == 'x' && s[1] == 'c')
                {
                    Int += 90;
                    s = s.Substring(2, s.Length - 2);
                }
                else if (s[0] == 'c')
                {
                    Int += 100;
                    s = s.Substring(1, s.Length - 1);
                }
                else if (s[0] == 'x' && s[1] == 'l')
                {
                    Int += 40;
                    s = s.Substring(2, s.Length - 2);
                }
                else if (s[0] == 'l')
                {
                    Int += 50;
                    s = s.Substring(1, s.Length - 1);
                }
                else if (s[0] == 'i' && s[1] == 'x')
                {
                    Int += 9;
                    s = s.Substring(2, s.Length - 2);
                }
                else if (s[0] == 'x')
                {
                    Int += 10;
                    s = s.Substring(1, s.Length - 1);
                }
                else if (s[0] == 'i' && s[1] == 'v')
                {
                    Int += 4;
                    s = s.Substring(2, s.Length - 2);
                }
                else if (s[0] == 'v')
                {
                    Int += 5;
                    s = s.Substring(1, s.Length - 1);
                }
                else if (s[0] == 'i')
                {
                    Int += 1;
                    s = s.Substring(1, s.Length - 1);
                }
                else
                {
                    continue;
                }
            }
            return Int;
    }
}