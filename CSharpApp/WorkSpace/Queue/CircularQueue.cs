using System.Diagnostics;

namespace CSharpApp.WorkSpace.Queue
{
    public class CircularQueue
    {
        protected int[] data;
        private const int DEFAULT_SIZE = 10;

        protected int end = 0;
        protected int front = 0;
        int size = 0;

        public CircularQueue() : this(DEFAULT_SIZE) { }

        public CircularQueue(int size)
        {
            this.data = new int[size];
        }

        public bool isFull()
        {
            return size == this.data.Length;
        }

        public bool isEmpty()
        {
            return size == 0;
        }

        public virtual bool Insert(int item)
        {
            if (isFull())
            {
                return false;
            }

            data[end++] = item;
            end = end % data.Length;
            size += 1;

            return true;
        }

        public int Remove()
        {
            if (isEmpty())
            {
                throw new Exception("Array is Empty");
            }

            int removed = data[front++];
            front = front % data.Length;
            size -= 1;

            return removed;
        }

        public int Front()
        {
            if (isEmpty())
            {
                throw new Exception("Array is Empty");
            }
            return data[front];
        }

        public void Display()
        {
            if (isEmpty())
            {
                throw new Exception("Array is Empty");
            }

            int i = front;
            do
            {
                System.Console.Write(data[i++] + " <- ");
                i %= data.Length;
            } while (i != end);

            System.Console.WriteLine("END");
        }
    }
}