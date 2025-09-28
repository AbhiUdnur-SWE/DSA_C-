using System.Drawing;
using System.Text;

namespace WorkSpace.LinkedList
{
    public class LLHT
    {
        private Node? Head;
        private Node? Tail;
        private int size;

        public LLHT()
        {
            size = 0;
        }

        public int Size => size;

        public void InsertFirst(int data)
        {
            Node node = new Node(data);
            node.next = Head;
            Head = node;

            if (Tail is null)
            {
                Tail = Head;
            }

            size += 1;
        }

        public void InsertLast(int data)
        {
            if (Tail is null)
            {
                InsertFirst(data);
                return;
            }

            Node node = new(data);
            Tail.next = node;
            Tail = node;

            size += 1;
        }

        public void Insert(int data, int index)
        {

            if (index == 0)
            {
                InsertFirst(data);
                return;
            }

            if (index == size)
            {
                InsertLast(data);
                return;
            }

            Node? node = Head;
            for (int i = 1; i < index; i++)
            {
                node = node?.next;
            }

            if (node != null)
            {
                var newNode = new Node(data);
                var temp = node.next;
                node.next = newNode;
                newNode.next = temp;
            }

            size += 1;
        }


        public int? DelFirst()
        {
            int? temp = Head?.data;
            Head = Head?.next;

            if (Head is null)
            {
                Tail = null;
            }

            size -= 1;
            return temp;
        }

        public int? getNodeData(int index)
        {
            return getNode(index)?.data;
        }

        private Node? getNode(int index)
        {
            var runner = Head;
            for (int i = 0; i < index; i++)
            {
                runner = runner?.next;
            }

            return runner;
        }

        public int? DelLast()
        {
            if (size <= 1)
            {
                return DelFirst();
            }

            var runner = Head;

            runner = getNode(size - 2);

            var delNode = Tail?.data;
            Tail = runner;

            if (Tail != null)
            {
                Tail.next = null;
            }

            size -= 1;
            return delNode;
        }

        public int? del(int index)
        {
            if (index == 0)
            {
                return DelFirst();
            }

            if (index == size - 1)
            {
                return DelLast();
            }

            var prevNode = Head;
            for (int i = 1; i < index; i++)
            {
                prevNode = prevNode?.next;
            }

            var toDelNode = prevNode?.next;

            if (prevNode != null)
            {
                prevNode.next = toDelNode?.next;
                // prevNode.next = prevNode?.next?.next;
            }

            size -= 1;
            return toDelNode?.data;
            // return prevNode?.next.data;
        }

        public void DisplayLL()
        {
            Node? runner = Head;

            if (runner is null)
            {
                return;
            }

            while (runner != null)
            {
                Console.Write($"{runner.data} -> ");
                runner = runner.next;
            }

            Console.Write("End");
            Console.WriteLine();
        }

        private class Node
        {
            public Node? next;
            public int data;

            public Node(int data)
            {
                this.data = data;
            }
        }
    }
}