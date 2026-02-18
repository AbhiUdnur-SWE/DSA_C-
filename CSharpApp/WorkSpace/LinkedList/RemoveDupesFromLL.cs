using Node = WorkSpace.LinkedList.LLHT.Node;

namespace WorkSpace.LinkedList
{
    public static class RemoveDupesFromLL
    {
        public static Node RemoveDupes(Node head)
        {
            var temp = head;

            while (temp.next is not null)
            {
                if (temp.data == temp.next.data)
                    temp.next = temp.next.next;
                else
                    temp = temp.next;
            }

            return head;
        }
    }
    
}