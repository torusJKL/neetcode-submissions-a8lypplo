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
    public ListNode MergeTwoLists(ListNode list1, ListNode list2) {
        ListNode mergedListHead = new ListNode(-1);
        ListNode mergedListCurr = mergedListHead;

        while (list1 != null && list2 != null) {
            if (list1.val < list2.val) {
                mergedListCurr.next = list1;
                mergedListCurr = mergedListCurr.next;
                list1 = list1.next;
            } else {
                mergedListCurr.next = list2;
                mergedListCurr = mergedListCurr.next;
                list2 = list2.next;
            }
        }

        if (list1 != null) {
            mergedListCurr.next = list1;
        } else if (list2 != null) {
            mergedListCurr.next = list2;
        }

        return mergedListHead.next;
    }
}