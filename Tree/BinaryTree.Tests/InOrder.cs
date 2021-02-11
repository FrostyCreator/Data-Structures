using Xunit;
using System.Collections.Generic;

namespace BinaryTree.Tests
{
    public class InOrder
    {
        [Fact]
        public void InOrder_CheckCorrect()
        {
            var tree = new BinaryTree<int>(10);
            // left branch
            tree.Add(8);
            tree.Add(9);
            tree.Add(5);
            tree.Add(3);
            tree.Add(7);
            // right branch
            tree.Add(15);
            tree.Add(18);
            tree.Add(12);
            var expectedValue = new List<int> {3, 5, 7, 8, 9, 10, 12, 15, 18};
            var actualValues = new List<int>();
            
            tree.InOrder(v => actualValues.Add(v));
            
            Assert.Equal(expectedValue, actualValues);
        }
    }
}