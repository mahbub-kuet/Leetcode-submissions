public class Stack
    {
        // Push element x onto stack.
        LinkedList<int> list = new LinkedList<int>();
        public void Push(int x)
        {
            list.AddLast(x);
        }

        // Removes the element on top of the stack.
        public void Pop()
        {
            list.RemoveLast();
        }

        // Get the top element.
        public int Top()
        {
            return list.Last();
                 
        }

        // Return whether the stack is empty.
        public bool Empty()
        {
            if(list.Count>0)
            {
                return false;
            }
            return true;
        }
    }