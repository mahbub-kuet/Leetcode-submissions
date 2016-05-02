public class Solution {
    public IList<string> Anagrams(string[] strs) {
         
        Dictionary<string, string> dic = new Dictionary<string, string>();
            HashSet<string> result = new HashSet<string>();
            List<string> resultset = new List<string>();
            if(strs.Length<2)
              return resultset;
            
            foreach (string s in strs)
            {
                char[] ch = s.ToCharArray();
                Array.Sort(ch);
                string s1 = new string(ch);
                if (!dic.ContainsKey(s1))
                {
                    dic.Add(s1, s);
                }
                else 
                {
                   
                        resultset.Add(s);
                        result.Add(dic[s1]);                 
                    
                }
            }
            
           foreach (string s in result)
            {
                resultset.Add(s);
            }
            return resultset;
        
    }
}