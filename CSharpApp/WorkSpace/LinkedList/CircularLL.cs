namespace WorkSpace.LinkedList
{
    public class CircularLL
    {
        Node? Head;
        Node? Tail;
        int size;

        public CircularLL()
        {
            size = 0;
        }

        public void AddNode(int val)
        {
            Node node = new(val);

            if (Head is null)
            {
                Head = node;
                Tail = node;
                node.next = node;

                return;
            }

            Tail!.next = node;
            node.next = Head;
            Tail = node;

            size++;
        }

        public void Display()
        {
            var runner = Head;

            do
            {
                Console.Write($" {runner?.data} -> ");
                runner = runner?.next;

            } while (runner != Head);
            Console.WriteLine("Loop");

            Console.WriteLine($"Tail: {Tail?.data}");
        }

        public void delete(int val)
        {
            if (Head is null)
            {
                return;
            }

            if (Head.data == val && Tail?.data == val)
            {
                Head = null;
                Tail = null;
            }

            if (Head?.data == val)
            {
                Head = Head.next;
                Tail!.next = Head;
            }

            var runner = Head;
            do
            {
                var n = runner?.next;

                if (n?.data == val && n == Tail)
                {
                    runner!.next = n.next;
                    Tail = runner;
                    break; 
                }
                if (n?.data == val)
                {
                    runner!.next = n.next;
                    break;   
                }
                runner = runner?.next;
            } while (runner != Head);

        }
        private class Node
        {
            public int data;
            public Node? next;

            public Node(int val)
            {
                data = val;
            }
        }
    }

}