using System;

namespace BinaryTree
{
    public class BinaryTree<T> 
        where T : IComparable<T>
    {
        public BinaryTreeNode<T> Root { get; private set; }
        public int Count { get; private set; }

        public BinaryTree() { }
        public BinaryTree(T value)
        {
            Root = new BinaryTreeNode<T>(value);
            Count = 1;
        }

        public void Add(T value)
        {
            if (Root == null)
            {
                Root = new BinaryTreeNode<T>(value);
                Count++;
                return;
            }
                
            Add(Root, value);
        }

        private void Add(BinaryTreeNode<T> node, T value)
        {
            if (value.CompareTo(node.Value) < 0)
            {
                if (node.Left == null)
                {
                    node.Left = new BinaryTreeNode<T>(value);
                    Count++;
                }
                else
                {
                    Add(node.Left, value);
                }
            }
            else
            {
                if (node.Right == null)
                {
                    node.Right = new BinaryTreeNode<T>(value);
                    Count++;
                }
                else
                {
                    Add(node.Right, value);
                }
            }
        }

        public void PreOrder(Action<T> action)
        {
            if (Root != null)
            {
                PreOrder(Root, action);
            }
        }

        private void PreOrder(BinaryTreeNode<T> node, Action<T> action)
        {
            action(node.Value);

            if (node.Left != null)
            {
                PreOrder(node.Left, action);
            }

            if (node.Right != null)
            {
                PreOrder(node.Right, action);
            }
        }

        public void InOrder(Action<T> action)
        {
            if (Root != null)
            {
                InOrder(Root, action);
            }
        }

        private void InOrder(BinaryTreeNode<T> node, Action<T> action)
        {
            if (node.Left != null)
            {
                InOrder(node.Left, action);
            }

            action(node.Value);
            
            if (node.Right != null)
            {
                InOrder(node.Right, action);
            }
        }

        public void PostOrder(Action<T> action)
        {
            if (Root != null)
            {
                PostOrder(Root, action);
            }
        }

        private void PostOrder(BinaryTreeNode<T> node, Action<T> action)
        {
            if (node.Left != null)
            {
                PostOrder(node.Left, action);
            }

            if (node.Right != null)
            {
                PostOrder(node.Right, action);
            }
            
            action(node.Value);
        }
    }
}