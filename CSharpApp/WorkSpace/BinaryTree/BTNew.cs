


namespace WorkSpace.BinaryTree
{
    public class BTNew
    {
        public void Populate()
        {
            System.Console.Write(" Enter root node : ");
            if (int.TryParse(Console.ReadLine(), out var val))
            {
                root = new Node(val);
                Populate(root);
                System.Console.WriteLine();
            }
        }

        private void Populate(Node node)
        {
            System.Console.Write($"enter node left to {node.Val} : ");
            if (int.TryParse(Console.ReadLine(), out var leftVal))
            {
                node.Left = new(leftVal);
                Populate(node.Left);
            }

            System.Console.Write($"enter node right to  {node.Val} : ");
            if (int.TryParse(Console.ReadLine(), out var rightVal))
            {
                node.Right = new(rightVal);
                Populate(node.Right);
            }
        }

        public void Display()
        {
            Display(root, "", false);
        }

        private void Display(Node? node, string indent, bool isLeft)
        {
            if (node is null)
            {
                return;
            }

            System.Console.WriteLine(indent + (isLeft ? "├── " : "└── ") + node.Val);

            var childIndent = indent + (isLeft ? "│   " : "    ");
            if (node.Left != null || node.Right != null)
            {
                Display(node.Left, childIndent, true);
                Display(node.Right, childIndent, false);
            }
        }


        public void PreOrder()
        {
            PreOrder(root);
        }

        private void PreOrder(Node? node)
        {
            if (node is null)
            {
                return;
            }

            System.Console.WriteLine(node.Val + " -> ");
            PreOrder(node.Left!);
            PreOrder(node.Right!);
        }


        public void PostOrder()
        {
            PostOrder(root);
        }

        private void PostOrder(Node? node)
        {
            if (node is null)
            {
                return;
            }

            PostOrder(node.Left);
            PostOrder(node.Right);
            System.Console.WriteLine(node.Left!.Val);
        }

        public void InOrder()
        {
            InOrder(root);
        }

        private void InOrder(Node? node)
        {
            if (node is null)
            {
                return;
            }

            InOrder(node.Left);
            System.Console.WriteLine(node.Left!.Val);
            InOrder(node.Right);
        }

        private Node? root;
        private class Node
        {
            public int Val;
            public Node? Left;
            public Node? Right;
            public Node(int val)
            {
                this.Val = val;
            }
        }
    }
}