using System;
using System.Collections;
using System.Collections.Generic;
/*合并两个有序链表
 * 递归或迭代
 
     */
public class Solution
{
    public ListNode MergeTwoLists(ListNode l1, ListNode l2)
    {
        // if(l1==null)return l2;
        // if(l2==null)return l1;
        // if(l1.val>l2.val) {
        //     l2.next=MergeTwoLists(l1,l2.next);
        //     return l2;
        // }else{
        //     l1.next=MergeTwoLists(l1.next,l2);
        //     return l1;
        // }
        ListNode head = new ListNode(-1);
        ListNode nextNode = head;
        while (l1 != null && l2 != null)
        {
            if (l1.val > l2.val)
            {
                nextNode.next = l2;
                l2 = l2.next;
            }
            else
            {
                nextNode.next = l1;
                l1 = l1.next;
            }
            nextNode = nextNode.next;
        }
        nextNode.next = l1 == null ? l2 : l1;
        return head.next;
    }
}
