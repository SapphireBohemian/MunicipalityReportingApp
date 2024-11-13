using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MunicipalityReportingApp
{
    public class MinHeap
    {
        private List<ServiceRequest> heap;

        public MinHeap()
        {
            heap = new List<ServiceRequest>();
        }

        public void Insert(ServiceRequest request)
        {
            heap.Add(request);
            HeapifyUp(heap.Count - 1);
        }

        public ServiceRequest ExtractMin()
        {
            if (heap.Count == 0)
                throw new InvalidOperationException("Heap is empty.");

            ServiceRequest min = heap[0];
            heap[0] = heap[heap.Count - 1];
            heap.RemoveAt(heap.Count - 1);
            HeapifyDown(0);
            return min;
        }

        private void HeapifyUp(int index)
        {
            while (index > 0)
            {
                int parentIndex = (index - 1) / 2;
                if (heap[index].SubmissionDate >= heap[parentIndex].SubmissionDate)
                    break;

                // Swap
                var temp = heap[index];
                heap[index] = heap[parentIndex];
                heap[parentIndex] = temp;

                index = parentIndex;
            }
        }

        private void HeapifyDown(int index)
        {
            int lastIndex = heap.Count - 1;
            while (index <= lastIndex)
            {
                int leftChildIndex = 2 * index + 1;
                int rightChildIndex = 2 * index + 2;
                int smallestIndex = index;

                if (leftChildIndex <= lastIndex && heap[leftChildIndex].SubmissionDate < heap[smallestIndex].SubmissionDate)
                    smallestIndex = leftChildIndex;

                if (rightChildIndex <= lastIndex && heap[rightChildIndex].SubmissionDate < heap[smallestIndex].SubmissionDate)
                    smallestIndex = rightChildIndex;

                if (smallestIndex == index)
                    break;

                // Swap
                var temp = heap[index];
                heap[index] = heap[smallestIndex];
                heap[smallestIndex] = temp;

                index = smallestIndex;
            }
        }
    }
}