public class Solution {
    public string SimplifyPath(string path) {
        Stack<string> stack = new Stack<string>();
        int i = 0;
        while (true)
        {
            int newIndex = path.Substring(i).IndexOf("/");
            if(newIndex == -1)
            {
                if(path.Substring(i) == "..")
                    {if(stack.Count > 0) stack.Pop();}
                else if (path.Substring(i) != ".")
                    stack.Push(path.Substring(i));
                break;
            }
            string tmp = path.Substring(i, newIndex + 1);
            if (String.Equals(tmp, "../"))
            {
                if (stack.Count > 0) stack.Pop();
            }
            else if (!String.Equals(tmp, "./") && !String.Equals(tmp, "/"))
                stack.Push(tmp);
            i = newIndex + i + 1;
            if (i > path.Length - 1) break;
        }
        if (stack.Count == 0) return "/";
        StringBuilder sb = new StringBuilder();
        while (stack.Count > 0)
            sb.Insert(0, stack.Pop());
        sb.Insert(0, "/");
        if (sb[sb.Length - 1] == '/') sb.Length--;
        return sb.ToString();
    }
}