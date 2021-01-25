using Xunit;

namespace CircularLinkedList.Tests
{
    public class FindTest
    {
        [Fact]
        public void Find_FindInEmptyList_ReturnNull()
        {
            var list = new CircularLinkedList<int>();

            var actual = list.Find(5);
            
            Assert.Null(actual);
        }
        
        [Fact]
        public void Find_InListThatNotContainSearchedItem_ReturnNull()
        {
            var list = new CircularLinkedList<int>(5);
            list.AddLast(5);
            list.AddLast(10);

            var actual = list.Find(15);
            
            Assert.Null(actual);
        }
        
        [Fact]
        public void Find_InListThatContainSearchedItemInLastPosition_ReturnThisItem()
        {
            var list = new CircularLinkedList<int>(5);
            list.AddLast(5);
            list.AddLast(10);

            int actual = list.Find(10).Value;
            
            Assert.Equal(10, actual);
        }
        
        [Fact]
        public void Find_InListThatContainSearchedItemInCenter_ReturnThisItem()
        {
            var list = new CircularLinkedList<int>(5);
            list.AddLast(5);
            list.AddLast(10);

            int actual = list.Find(5).Value;
            
            Assert.Equal(5, actual);
        }
    }
}