using System;

namespace BinaryTree
{
    public class BinaryTreeNode<T>
        where T: IComparable<T>
    {
        public BinaryTreeNode<T> Left { get; internal set; }
        public BinaryTreeNode<T> Right { get; internal set; }
        public T Value { get; set; }

        public BinaryTreeNode(T value)
        {
            Value = value;
        }
    }
}