namespace WorkSpace.LinkedList
{
    public class DoublyLL
    {

        Node? Head;
        Node? Tail;
        int size;

        public DoublyLL()
        {
            size = 0;
        }

        public void AddNode(int data)
        {
            Node node;
            if (Head is not null)
            {
                node = new(data);
                node.next = Head;
                Head.prev = node;
                Head = node;

                size += 1;
                return;

            }
            node = new(data);
            node.next = Head;
            Head = node;

            if (Tail is null)
            {
                Tail = Head;
            }
            size += 1;
        }

        public void InsertLast(int val)
        {
            Node node = new(val);

            if (Tail is null)
            {
                AddNode(val);
                return;
            }
            
            Tail.next = node;
            node.prev = Tail;
            Tail = node;
        }
        public void DisplayLL()
        {
            var runner = Head;

            while (runner != null)
            {
                Console.Write($"{runner.data} -> ");
                runner = runner.next;
            }

            Console.WriteLine("end");

            runner = Head;
            while (runner != null)
            {
                Console.WriteLine($"{runner?.prev?.data.ToString() ?? "null"}"
                + $" {runner?.data} {runner?.next?.data.ToString() ?? "null"}");

                runner = runner?.next;
            }
            
        }
        public void DisplayLLRev()
        {
            var runner = Tail;

            while (runner != null)
            {
                Console.Write($"{runner.data} -> ");
                runner = runner.prev;
            }

            Console.WriteLine("end");
        }

        private class Node
        {
            public int data;
            public Node? next;
            public Node? prev;
            public Node(int x)
            {
                data = x;
            }
        }
    }
}