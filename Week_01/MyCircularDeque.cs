using System;
/*641.设计循环双端队列
 * 循环队列，需要通过取模来判断当前头与尾
 * 注意判断队列为空和已满的条件
 */
public class Solution
{
    int[] deque;
    int first = 0;
    int tail = 0;
    /** Initialize your data structure here. Set the size of the deque to be k. */
    public MyCircularDeque(int k)
    {

        if (k >= 0)
        {
            deque = new int[k + 1];
            first = 0;
            tail = 0;
        }
    }

    /** Adds an item at the front of Deque. Return true if the operation is successful. */
    public bool InsertFront(int value)
    {
        if (IsFull()) return false;
        first = (first + deque.Length - 1) % deque.Length;
        deque[first] = value;
        return true;
    }

    /** Adds an item at the rear of Deque. Return true if the operation is successful. */
    public bool InsertLast(int value)
    {
        if (IsFull()) return false;
        deque[tail] = value;
        tail = (tail + 1) % deque.Length;
        return true;
    }

    /** Deletes an item from the front of Deque. Return true if the operation is successful. */
    public bool DeleteFront()
    {
        if (IsEmpty()) return false;
        first = (first + 1) % deque.Length;
        return true;
    }

    /** Deletes an item from the rear of Deque. Return true if the operation is successful. */
    public bool DeleteLast()
    {
        if (IsEmpty()) return false;
        tail = (tail + deque.Length - 1) % deque.Length;
        return true;
    }

    /** Get the front item from the deque. */
    public int GetFront()
    {
        if (IsEmpty()) return -1;
        return deque[first];
    }

    /** Get the last item from the deque. */
    public int GetRear()
    {
        if (IsEmpty()) return -1;
        return deque[(tail + deque.Length - 1) % deque.Length];
    }

    /** Checks whether the circular deque is empty or not. */
    public bool IsEmpty()
    {
        if (tail == first) return true;
        return false;
    }

    /** Checks whether the circular deque is full or not. */
    public bool IsFull()
    {
        if (first == ((tail + 1) % deque.Length)) return true;
        return false;
    }
}
