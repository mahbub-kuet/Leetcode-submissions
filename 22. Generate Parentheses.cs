public class Solution {
    
     static List<string> resultSet = new List<string>();
     static int FinalDepth = 0;
   
        static bool IsValid(string exp)
        { 
            Stack<char> S= new Stack<char>();
            for (int i = 0; i < exp.Length; i++)
            {
                if (exp[i] == '(')
                    S.Push(exp[i]);
                else if (exp[i] == ')')
                {
                    if (S.Count==0 || (S.Peek()!='('))
                        return false;
                    else
                        S.Pop();
                }
            }
            return S.Count==0 ? true : false;
        }
        
        static void GenerateParenthesis(int depth,string s)
        {
           if (depth == FinalDepth)
            {
                if (IsValid(s))
                {
                    resultSet.Add(s);                   
                }
                return;
            }

            GenerateParenthesis(depth+1, s + "(");
            GenerateParenthesis(depth+1, s + ")");
        }
    public IList<string> GenerateParenthesis(int n) {
         resultSet.Clear();
         if(n==0)
         return resultSet;
         FinalDepth = n*2;
         GenerateParenthesis(1,"(");
         return resultSet;
        
    }
}