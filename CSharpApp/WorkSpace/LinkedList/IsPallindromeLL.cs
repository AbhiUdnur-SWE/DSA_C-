using Node = WorkSpace.LinkedList.LLHT.Node;
namespace WorkSpace.LinkedList
{
    public static class IsPallindromeLL
    {
        public static bool IsPallindrome(Node? head)
        {
            var slow = head;
            var fast = head;

            // find middle
            while (fast is not null && fast.next is not null)
            {
                fast = fast.next.next;
                slow = slow?.next;
            }

            // reverse the second half
            Node? temp = null;
            while (slow is not null)
            {
                var nxt = slow.next;
                slow.next = temp;
                temp = slow;
                slow = nxt;
            }

            //check is it?
            while (temp is not null)
            {
                if (temp.data != head.data)
                    return false;

                temp = temp.next;
                head = head.next;
            }

            return true;
        }
    }

}