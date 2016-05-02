public class Solution {
    
    public static bool ValidMatch(char a, char b)
        {
            if (a == '(' && b == ')')
                return true;
            else if (a == '{' && b == '}')
                return true;
            else if (a == '[' && b == ']')
                return true;
            else
                return false;
        }
    
    public bool IsValid(string s) {
        Stack<char> stack = new Stack<char>();
            foreach (char c in s)
            {
                if (c == '(' || c == '{' || c == '[')
                {
                    stack.Push(c);
                    continue;
                }
                if (c == ')' || c == '}' || c == ']')
                {                    
                    if (stack.Count < 1 || !ValidMatch(stack.Peek(),c))
                    {
                        return false;
                    }
                    else
                        stack.Pop();
                }
            }
            if(stack.Count==0)
                return true;
            else
                return false;
    }
}