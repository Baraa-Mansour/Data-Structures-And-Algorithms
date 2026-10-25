namespace DSA.Heaps
{
    public class MinHeap<T> where T : IComparable<T>
    {
        private readonly List<T> _heap;

        public MinHeap()
        {
            _heap = new List<T>();
        }

        public void Insert(T item)
        {
            _heap.Add(item);

            HeapifyUp();
        }
        private void HeapifyUp()
        {
            int index = _heap.Count - 1;

            while(index > 0)
            {
                int parentIndex = (index - 1) / 2;

                // Check if current is greater or equal parent
                if (_heap[index].CompareTo(_heap[parentIndex]) >= 0)
                    break;

                (_heap[index], _heap[parentIndex]) = (_heap[parentIndex], _heap[index]);

                index = parentIndex;
            }
        }

        public T Extract()
        {
            if (_heap.Count == 0)
                throw new InvalidOperationException("Heap Is Empty");

            T minValue = _heap[0];

            int lastIndex = _heap.Count - 1;
            _heap[0] = _heap[lastIndex];

            _heap.RemoveAt(lastIndex);

            HeapifyDown();

            return minValue;
        }
        private void HeapifyDown()
        {
            int index = 0;

            while (index < _heap.Count)
            {
                int leftChildIndex = (index * 2) + 1;
                int rightChildIndex = (index * 2) + 2;
                int minIndex = index;

                if (leftChildIndex < _heap.Count &&
                    _heap[leftChildIndex].CompareTo(_heap[minIndex]) < 0)
                {
                    minIndex = leftChildIndex;
                }

                if (rightChildIndex < _heap.Count &&
                    _heap[rightChildIndex].CompareTo(_heap[minIndex]) < 0)
                {
                    minIndex = rightChildIndex;
                }

                if (minIndex == index)
                    break;

                (_heap[index], _heap[minIndex]) = (_heap[minIndex], _heap[index]);

                index = minIndex;
            }
        }

        public T Peek()
        {
            if (_heap.Count == 0)
                throw new InvalidOperationException("Heap Is Empty");

            return _heap[0];
        }

        public void Print()
        {
            Console.WriteLine("\nHeap Elements: ");
            foreach (T value in _heap)
            {
                Console.Write(value + " ");
            }
            Console.WriteLine();
        }
    }
}
