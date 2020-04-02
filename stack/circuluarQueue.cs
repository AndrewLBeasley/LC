public class MyCircularQueue {
    int[] queue;
    int initialQueueSize = 0;
    int head = 0;
    int tail = 0;

    /** Initialize your data structure here. Set the size of the queue to be k. */
    public MyCircularQueue(int k) {
        initialQueueSize = k;
        Array.Resize(ref queue, initialQueueSize);
        head = -1;
        tail = -1;
    }

    /** Insert an element into the circular queue. Return true if the operation is successful. */
    public bool EnQueue(int value) {
        Console.WriteLine(Front());
        Console.WriteLine(Rear());
        Console.WriteLine(queue);
        queue[Array.IndexOf(queue, Front()) - 1] = value;


        if(head == queue[Front()]) {
            ++head;
        } else {
            ++tail;
        }

        return true;
    }

    /** Delete an element from the circular queue. Return true if the operation is successful. */
    public bool DeQueue() {
        if(IsEmpty()) {
            return false;
        }

        if(head == queue[Rear()]) {
            ++head;
        } else {
            ++tail;
        }

        return true;
    }

    /** Get the front item from the queue. */
    public int Front() {
        return Array.IndexOf(queue, head) < Array.IndexOf(queue, tail) ? head : tail;
    }

    /** Get the last item from the queue. */
    public int Rear() {
        return Array.IndexOf(queue, head) > Array.IndexOf(queue, tail) ? head : tail;
    }

    /** Checks whether the circular queue is empty or not. */
    public bool IsEmpty() {
        return queue.Length == 0;
    }

    /** Checks whether the circular queue is full or not. */
    public bool IsFull() {
        return queue.Length == initialQueueSize;
    }
}