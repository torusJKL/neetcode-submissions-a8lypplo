/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
 
public class Solution {
    public ListNode ReverseList(ListNode head) {
        if (head?.next == null){
            return head;
        }

        var nodeStack = new Stack<ListNode>();
        while (head != null){
            nodeStack.Push(head);
            head = head.next;
        }

        head = nodeStack.Pop();
        var cur = head;
        while (nodeStack.Count() > 0){
            cur.next = nodeStack.Pop();
            cur = cur.next;
        }
        cur.next = null;

        return head;
    }
}
