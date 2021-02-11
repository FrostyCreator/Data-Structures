using System.Collections.Generic;
using Xunit;

namespace BinaryTree.Tests
{
    public class Preorder
    {
        [Fact]
        public void Preorder_CheckCorrect()
        {
            var tree = new BinaryTree<int>(10);
            // left branch
            tree.Add(5);
            tree.Add(8);
            tree.Add(9);
            tree.Add(7);
            tree.Add(3);
            // right branch
            tree.Add(15);
            tree.Add(18);
            tree.Add(12);
            var expectedValue = new List<int> {10, 5, 3, 8, 7, 9, 15, 12, 18};
            var actualValues = new List<int>();
            
            tree.PreOrder(v => actualValues.Add(v));
            
            Assert.Equal(expectedValue, actualValues);
        }
    }
}