using Node = WorkSpace.LinkedList.LLHT.Node;

namespace WorkSpace.LinkedList
{
    public class RemoveAllOccrfromLL
    {
        public static Node Remove(Node head, int val)
        {
            var dummy = new Node(-1);
            dummy.next = head;

            var temp = dummy;
            while (temp.next is not null)
            {
                if (temp.next.data == val)
                    temp.next = temp.next.next;
                else
                    temp = temp.next;
            }

            return dummy.next;
        }
    }
}