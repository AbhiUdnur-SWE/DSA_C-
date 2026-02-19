
using Node = WorkSpace.LinkedList.LLHT.Node;

namespace WorkSpace.LinkedList
{
    public static class MergerTwoLList
    {
        public static LLHT.Node? MergeTwoLL(Node? node1, Node? node2)
        {
            var dummyNode = new Node(-1);

            var temp = dummyNode;

            while (node1 is not null && node2 is not null)
            {
                if (node1.data <= node2.data)
                {
                    temp.next = new Node(node1.data);
                    node1 = node1.next;
                }
                else
                {
                    temp.next = new Node(node2.data);
                    node2 = node2.next;
                }

                temp = temp.next;
            }
            temp.next = node1 is not null ? node1 : node2;
            return dummyNode.next;
        }
    }
}