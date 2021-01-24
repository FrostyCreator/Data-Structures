using Xunit;

namespace DoublyLinkedList.Tests
{
    public class FindTest
    {
        [Fact]
        public void Find_SearchInEmptyList_ReturnNull()
        {
            var list = new DoublyLinkedList<int>();

            var actual = list.Find(5);
            
            Assert.Null(actual);
        }
        
        [Fact]
        public void Find_SearchItemThatInList_ReturnNode()
        {
            int value = 5;
            var list = new DoublyLinkedList<int>(0);
            list.AddLast(value);
            list.AddLast(10);

            var actual = list.Find(5);
            
            Assert.Equal(value, actual.Value);
        }
        
        [Fact]
        public void Find_SearchItemThatNotInList_ReturnNull()
        {
            var list = new DoublyLinkedList<int>(0);
            list.AddLast(5);
            list.AddLast(10);

            var actual = list.Find(15);
            
            Assert.Null(actual);
        }
    }
}