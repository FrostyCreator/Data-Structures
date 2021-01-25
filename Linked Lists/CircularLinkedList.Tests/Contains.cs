using Xunit;

namespace CircularLinkedList.Tests
{
    public class Contains
    {
        [Fact]
        public void Contains_SearchInEmptyList_ReturnFalse()
        {
            var list = new CircularLinkedList<int>();

            bool actual = list.Contains(0);

            Assert.False(actual);
        }
        
        [Fact]
        public void Contains_SearchInListThatContainSearchedItemInLastPosition_ReturnTrue()
        {
            var list = new CircularLinkedList<int>(0);
            list.AddLast(5);
            list.AddLast(10);

            bool actual = list.Contains(10);

            Assert.True(actual);
        }
        
        [Fact]
        public void Contains_SearchInListThatContainSearchedItemInCenter_ReturnTrue()
        {
            var list = new CircularLinkedList<int>(0);
            list.AddLast(5);
            list.AddLast(10);

            bool actual = list.Contains(5);

            Assert.True(actual);
        }
        
        [Fact]
        public void Contains_SearchInListThatNotContainSearchedItem_ReturnTrue()
        {
            var list = new CircularLinkedList<int>(0);
            list.AddLast(5);
            list.AddLast(10);

            bool actual = list.Contains(20);

            Assert.False(actual);
        }
    }
}