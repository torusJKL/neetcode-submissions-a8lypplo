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

        ListNode mergedListHead = null;
        ListNode mergedListCurr = null;
        ListNode nextNode1 = list1;
        ListNode nextNode2 = list2; 

        if (list1 == null && list2 == null){
            return null;
        }

        if (list1 == null){
            mergedListHead = list2;
            nextNode2 = list2.next;
            mergedListCurr = mergedListHead;
        }
        else if (list2 == null) {
            mergedListHead = list1;
            nextNode1 = list1.next;
            mergedListCurr = mergedListHead;
        }
        else {
            if (nextNode1.val < nextNode2.val){
                mergedListHead = nextNode1;
                mergedListCurr = mergedListHead;
                nextNode1 = nextNode1.next;
            }
            else {
                mergedListHead = nextNode2;
                mergedListCurr = mergedListHead;
                nextNode2 = nextNode2.next;
            }
        }

        while (nextNode1 != null || nextNode2 != null){
            if (nextNode1 == null){
                mergedListCurr.next = nextNode2;
                mergedListCurr = mergedListCurr.next;
                nextNode2 = nextNode2.next;
            }
            else if (nextNode2 == null){
                mergedListCurr.next = nextNode1;
                mergedListCurr = mergedListCurr.next;
                nextNode1 = nextNode1.next;
            }
            else {
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
        }

        return mergedListHead;
    }
}