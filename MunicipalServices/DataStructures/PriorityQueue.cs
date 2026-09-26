using System;
using System.Collections.Generic;

namespace MunicipalServices.DataStructures
{
    /// <summary>
    /// A generic binary min-heap priority queue. The element that compares as smallest
    /// is dequeued first. Enqueue and Dequeue are O(log n); Peek is O(1).
    /// </summary>
    public class PriorityQueue<T>
    {
        private readonly List<T> _heap = new List<T>();
        private readonly IComparer<T> _comparer;

        public PriorityQueue() : this(Comparer<T>.Default)
        {
        }

        public PriorityQueue(IComparer<T> comparer)
        {
            _comparer = comparer ?? throw new ArgumentNullException(nameof(comparer));
        }

        public int Count => _heap.Count;

        public void Enqueue(T item)
        {
            _heap.Add(item);
            SiftUp(_heap.Count - 1);
        }

        public T Peek()
        {
            if (_heap.Count == 0)
                throw new InvalidOperationException("The priority queue is empty.");
            return _heap[0];
        }

        public T Dequeue()
        {
            if (_heap.Count == 0)
                throw new InvalidOperationException("The priority queue is empty.");

            var top = _heap[0];
            var last = _heap.Count - 1;
            _heap[0] = _heap[last];
            _heap.RemoveAt(last);
            if (_heap.Count > 0)
                SiftDown(0);
            return top;
        }

        /// <summary>
        /// Returns every item in priority order without modifying the queue.
        /// </summary>
        public List<T> ToOrderedList()
        {
            var copy = new PriorityQueue<T>(_comparer);
            copy._heap.AddRange(_heap);

            var ordered = new List<T>(copy.Count);
            while (copy.Count > 0)
                ordered.Add(copy.Dequeue());
            return ordered;
        }

        private void SiftUp(int index)
        {
            while (index > 0)
            {
                var parent = (index - 1) / 2;
                if (_comparer.Compare(_heap[index], _heap[parent]) >= 0)
                    break;
                Swap(index, parent);
                index = parent;
            }
        }

        private void SiftDown(int index)
        {
            while (true)
            {
                var left = 2 * index + 1;
                var right = left + 1;
                var smallest = index;

                if (left < _heap.Count && _comparer.Compare(_heap[left], _heap[smallest]) < 0)
                    smallest = left;
                if (right < _heap.Count && _comparer.Compare(_heap[right], _heap[smallest]) < 0)
                    smallest = right;
                if (smallest == index)
                    break;

                Swap(index, smallest);
                index = smallest;
            }
        }

        private void Swap(int a, int b)
        {
            var temp = _heap[a];
            _heap[a] = _heap[b];
            _heap[b] = temp;
        }
    }
}
