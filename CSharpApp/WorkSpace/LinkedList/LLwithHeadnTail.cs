using System.Drawing;
using System.Text;

namespace WorkSpace.LinkedList
{
    public class LLHT
    {
        private Node? head;
        private Node? tail;
        private int size;

        public LLHT()
        {
            size = 0;
        }

        public int Size => size;

        public Node? Head => head;

        public void InsertFirst(int data)
        {
            Node node = new Node(data);
            node.next = head;
            head = node;

            if (tail is null)
            {
                tail = head;
            }

            size += 1;
        }

        public void InsertLast(int data)
        {
            if (tail is null)
            {
                InsertFirst(data);
                return;
            }

            Node node = new(data);
            tail.next = node;
            tail = node;

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

            Node? node = head;
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
            int? temp = head?.data;
            head = head?.next;

            if (head is null)
            {
                tail = null;
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
            var runner = head;
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

            var runner = head;

            runner = getNode(size - 2);

            var delNode = tail?.data;
            tail = runner;

            if (tail != null)
            {
                tail.next = null;
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

            var prevNode = head;
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
            Node? runner = head;

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

        public class Node
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