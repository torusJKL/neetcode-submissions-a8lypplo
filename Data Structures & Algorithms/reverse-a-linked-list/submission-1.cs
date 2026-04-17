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

        ListNode oldHead;
        var nextHead = head.next;
        var newTail = head;

        while (nextHead != null){
            oldHead = head;
            head = nextHead;
            nextHead = head.next;
            head.next = oldHead;
        }

        newTail.next = null;
        return head;
    }
}
