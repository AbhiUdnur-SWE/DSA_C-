// using System.Text;

// namespace WorkSpace.LinkedList
// {
//     public class Node
//     {
//         public int data;
//         public Node? nextNode;

//         public Node(int x)
//         {
//             nextNode = null;
//             data = x;
//         }
//     }

//     public class LinkList
//     {
//         Node? head = null;

//         public void AddNode(int x)
//         {
//             Node node = new(x);
//             node.nextNode = head;
//             head = node;
//         }

//         public void PrintLList()
// {
//             var runner = head;

//             while (runner != null)
//             {
//                 Console.Write($" {runner.data} ");
//                 runner = runner.nextNode;
//             }
//         }
//     }

// }