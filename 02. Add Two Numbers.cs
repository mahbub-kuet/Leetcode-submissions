public class Solution {
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
        
        ListNode head = new ListNode(0);
            ListNode current = head;
            bool carry = false;

            while (l1 != null || l2 != null)
            {
                int sum = 0;

                if (l1 == null)
                {       //If l1 is null, only proceed l2
                    sum = l2.val;
                    l2 = l2.next;
                }
                else if (l2 == null)
                {  //If l2 is null, only proceed l1
                    sum = l1.val;
                    l1 = l1.next;
                }
                else
                {               //If l1,l2 not null, proceed both
                    sum = l1.val + l2.val;
                    l1 = l1.next;
                    l2 = l2.next;
                }

                if (carry)           //check carry
                    sum++;

                if (sum >= 10)
                {        //check overflow
                    sum = sum - 10;
                    carry = true;
                }
                else
                    carry = false;

                current.next = new ListNode(sum);
                current = current.next;
            }

            if (carry)               //check last carry
                current.next = new ListNode(1);

            return head.next;
        
    }
}