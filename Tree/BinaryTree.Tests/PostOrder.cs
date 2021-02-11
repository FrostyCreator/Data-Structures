using System.Collections.Generic;
using Xunit;

namespace BinaryTree.Tests
{
    public class PostOrder
    {
        [Fact]
        public void PostOrder_CheckCorrect()
        {
            var tree = new BinaryTree<int>(10);
            // left branch
            tree.Add(5);
            tree.Add(8);
            tree.Add(9);
            tree.Add(3);
            tree.Add(7);
            // right branch
            tree.Add(15);
            tree.Add(18);
            tree.Add(12);
            var expectedValue = new List<int> {3, 7, 9, 8, 5, 12, 18, 15, 10};
            var actualValues = new List<int>();
            
            tree.PostOrder(v => actualValues.Add(v));
            
            Assert.Equal(expectedValue, actualValues);
        }
    }
}