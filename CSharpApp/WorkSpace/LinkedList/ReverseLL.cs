using Node = WorkSpace.LinkedList.LLHT.Node;

namespace WorkSpace.LinkedList
{
    public static class ReverseLL
    {
        public static Node? Reverse(Node head)
        {
            Node? p = null;
            var c = head;

            while (c is not null)
            {
                var temp = c.next;

                c.next = p;
                p = c;
                c = temp;
            }

            return p;
        } 
    }
}