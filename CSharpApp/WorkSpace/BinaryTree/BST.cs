using System.ComponentModel.DataAnnotations;

namespace WorkSpace.BinaryTree
{
    public class BST
    {

        private int Height(Node node)
        {
            if (node is null)
            {
                return -1;
            }

            return node.Height;
        }

        public void Insert(int val)
        {
            _root = Insert(val, _root);
        }

        private Node Insert(int val, Node? node)
        {
            if (node is null)
            {
                node = new(val);
                return node;
            }

            if (node.value > val)
            {
                node.Left = Insert(val, node.Left!);
            }
            if (node.value < val)
            {
                node.Right = Insert(val, node.Right!);
            }

            node.Height = Math.Max(Height(node.Left!), Height(node.Right!)) + 1;

            return node;
        }

        public void Populate(int[] num)
        {
            for (int i = 0; i < num.Count(); i++)
            {
                Insert(num[i]);
            }
        }

        public void Display()
        {
            Display(_root, "", false);

        }

        public bool Balanced()
        {
            return Balanced(_root);
        }

        private bool Balanced(Node? node)
        {
            if (node is null)
            {
                return true;
            }

            return Math.Abs(Height(node.Left!) - Height(node.Right!)) <= 1
                    && Balanced(node.Right)
                    && Balanced(node.Left);
        }

        private void Display(Node? node, string indent, bool isLeft)
        {
            if (node is null)
            {
                return;
            }

            // Print right subtree first
            if (node.Right != null)
            {
                Display(node.Right, indent + (isLeft ? "│   " : "    "), false);
            }

            System.Console.Write(indent);
            if (isLeft)
            {
                System.Console.Write("└── ");
            }
            else
            {
                System.Console.Write("┌── ");
            }
            System.Console.WriteLine(node.value);

            if (node.Left != null)
            {
                Display(node.Left, indent + (isLeft ? "    " : "│   "), true);
            }
        }

        private Node? _root;

        private class Node
        {
            public int value;
            public Node? Right;
            public Node? Left;
            public int Height;
            public Node(int val)
            {
                value = val;
            }
        }
    }
}