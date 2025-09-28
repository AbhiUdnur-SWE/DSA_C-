using System.Drawing;

namespace CSharpApp.WorkSpace.Queue
{
    public class DynamicCircularQueue : CircularQueue
    {
        public DynamicCircularQueue() : base() { }

        public DynamicCircularQueue(int size) : base(size) { }

        public override bool Insert(int item)
        {
            if (this.isFull())
            {
                int[] temp = new int[data.Length * 2];

                for (int i = 0; i < data.Length; i++)
                {
                    temp[i] = data[(front + i) % data.Length];
                }

                front = 0;
                end = data.Length;
                data = temp;
            }

            return base.Insert(item);
        }
    }
}