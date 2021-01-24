using Xunit;

namespace DoublyLinkedList.Tests
{
    public class ContainsTest
    {
        [Fact]
        public void Contains_SearchInEmptyList_ReturnFalse()
        {
            var list = new DoublyLinkedList<int>();

            bool actual = list.Contains(5);
            
            Assert.False(actual);
        }
        
        [Fact]
        public void Contains_SearchItemThatInList_ReturnTrue()
        {
            var list = new DoublyLinkedList<int>(0);
            list.AddLast(5);
            list.AddLast(10);

            bool actual = list.Contains(5);
            
            Assert.True(actual);
        }
        
        [Fact]
        public void Contains_SearchItemThatNotInList_ReturnFalse()
        {
            var list = new DoublyLinkedList<int>(0);
            list.AddLast(5);
            list.AddLast(10);

            bool actual = list.Contains(15);
            
            Assert.False(actual);
        }
    }
}