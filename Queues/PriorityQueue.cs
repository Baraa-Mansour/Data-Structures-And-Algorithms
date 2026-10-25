using DSA.Heaps;

namespace DSA.Queues
{
    public class PriorityQueueNode<T> : IComparable<PriorityQueueNode<T>>
    {
        public int Priority { get; set; }
        public T Value { get; set; }

        public PriorityQueueNode(int priority, T value)
        {
            Priority = priority;
            Value = value;
        }

        public int CompareTo(PriorityQueueNode<T>? other)
        {
            if (other == null) return 1;

            return Priority.CompareTo(other.Priority);
        }
    }

    public class PriorityQueue<T>
    {
        private readonly MinHeap<PriorityQueueNode<T>> _heap;

        public PriorityQueue()
        {
            _heap = new MinHeap<PriorityQueueNode<T>>();
        }

        public void Push(T value, int priority)
        {
            var newNode = new PriorityQueueNode<T>(priority, value);
            _heap.Insert(newNode);
        }
        public PriorityQueueNode<T> Peek()
        {
            return _heap.Peek();
        }
        public PriorityQueueNode<T> Pop()
        {
            return _heap.Extract();
        }
    }
}
