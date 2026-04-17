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
        ListNode nextNode1 = list1;
        ListNode nextNode2 = list2; 

        while (nextNode1 != null && nextNode2 != null){
            if (nextNode1.val < nextNode2.val){
                mergedListCurr.next = nextNode1;
                mergedListCurr = mergedListCurr.next;
                nextNode1 = nextNode1.next;
            }
            else {
                mergedListCurr.next = nextNode2;
                mergedListCurr = mergedListCurr.next;
                nextNode2 = nextNode2.next;
            }
        }

        if (nextNode1 != null){
            mergedListCurr.next = nextNode1;
        }
        else if (nextNode2 != null){
            mergedListCurr.next = nextNode2;
        }

        return mergedListHead.next;
    }
}