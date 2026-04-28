using System;
using System.Collections;
using System.Collections.Generic;

namespace WorkSpace.BinaryTree
{
    public class BinaryTree
    {
        private TreeNode root;
        public BinaryTree(TreeNode root)
        {
            this.root = root;
        }

        public void PreOrder()
        {
            PreOrder(root);
        }

        public void InOrder()
        {
            InOrder(root);
        }

        public void PostOrder()
        {
            PostOrder(root);
        }

        private static void PreOrder(TreeNode node)
        {
            if (node is null)
                return;

            System.Console.WriteLine(node.data);
            PreOrder(node.left);
            PreOrder(node.right);
        }

        public static void InOrder(TreeNode node)
        {
            if (node is null)
                return;

            PreOrder(node.left);
            System.Console.WriteLine(node.data);
            PreOrder(node.right);
        }

        public static void PostOrder(TreeNode node)
        {
            if (node is null)
                return;

            PreOrder(node.left);
            PreOrder(node.right);
            System.Console.WriteLine(node.data);
        }

        public void LevelOrder()
        {
            if (root == null)
                return;

            Queue<TreeNode> queue = new();
            queue.Enqueue(root);

            while (queue.Count != 0)
            {
                root = queue.Dequeue();
                System.Console.WriteLine(root.data);

                if (root.left != null)
                    queue.Enqueue(root.left);

                if (root.right != null)
                    queue.Enqueue(root.right);
            }
        }

        public void LevelOrder(int val)
        {
            if (root == null)
                return;

            Queue<TreeNode> queue = new();
            queue.Enqueue(root);

            while (queue.Count != 0)
            {
                root = queue.Dequeue();
                if (root.data == val)
                    System.Console.WriteLine(true);

                if (root.left != null)
                    queue.Enqueue(root.left);

                if (root.right != null)
                    queue.Enqueue(root.right);
            }
        }

        public void InsertBT(TreeNode node)
        {
            if (root == null)
            {
                root = node;
                return;
            }

            Queue<TreeNode> queue = new();
            queue.Enqueue(root);

            while (queue.Count != 0)
            {
                root = queue.Dequeue();

                if (root.left == null)
                {
                    root.left = node;
                    return;
                }

                if (root.right == null)
                {
                    root.right = node;
                    return;
                }

                if (root.left != null)
                    queue.Enqueue(root.left);

                if (root.right != null)
                    queue.Enqueue(root.right);
            }
        }

    }

    public class TreeNode
    {
        public int data;
        public TreeNode left;
        public TreeNode right;

        public TreeNode(int data)
        {
            this.data = data;
        }

    }

}