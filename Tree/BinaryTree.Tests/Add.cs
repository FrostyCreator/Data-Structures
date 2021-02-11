using System;
using Xunit;
using Xunit.Abstractions;

namespace BinaryTree.Tests
{
    public class Add
    {
        [Fact]
        public void Add_CheckCorrectInsertion()
        {
            var tree = new BinaryTree<int>(10);
            // left branch
            tree.Add(5);
            tree.Add(8);
            tree.Add(3);
            // right branch
            tree.Add(15);
            tree.Add(12);
            tree.Add(18);

            var valuesInTree = new int[]
            {
                tree.Root.Value,                // 10
                tree.Root.Left.Value,           // 5
                tree.Root.Left.Left.Value,      // 3
                tree.Root.Left.Right.Value,     // 8
                
                tree.Root.Right.Value,          // 15
                tree.Root.Right.Left.Value,     // 12
                tree.Root.Right.Right.Value,    // 18
            };
            var expectedValue = new int[] {10, 5, 3, 8, 15, 12, 18};
                
            Assert.Equal(expectedValue, valuesInTree);
        }
        
        [Fact]
        public void Add_Add5Value_CountEqual5()
        {
            var tree = new BinaryTree<int>(10);
            tree.Add(5);
            tree.Add(8);
            tree.Add(3);
            tree.Add(15);

            int count = 5;
            
            Assert.Equal(count, tree.Count);
        }
    }
}