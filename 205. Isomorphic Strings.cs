public class Solution {
    public bool IsIsomorphic(string s, string t) {
        Dictionary<char, char> dic = new Dictionary<char, char>();
         Dictionary<char, char> dic1 = new Dictionary<char, char>();
          for (int i = 0; i < s.Length; i++)
          {
              try
              {
                  dic.Add(s[i],t[i]);
                  dic1.Add(t[i],s[i]);
              }
              catch 
              {
                  //char c= dic[s1[i]];
                  if (dic[s[i]] != t[i] || dic1[t[i]] != s[i])
                      return false;
              }
 
          }
          return true;
    }
}