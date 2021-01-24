using Xunit;

namespace DoublyLinkedList.Tests
{
    public class AddFirstTest
    {
        [Fact]
        public void AddFirst_AddValueToEmptyList_ThisValueIsFirstAndLast()
        {
            var list = new DoublyLinkedList<int>();
            int value = 10;
            
            list.AddFirst(value);
            int first = list.First.Value;
            int last = list.Last.Value;
            
            Assert.Equal(value, first);
            Assert.Equal(value, last);
        }
        
        [Fact]
        public void AddFirst_AddValueToNonEmptyList_FirstEqualValue()
        {
            var list = new DoublyLinkedList<int>(5);
            int value = 10;
            
            list.AddFirst(value);
            int first = list.First.Value;
            
            Assert.Equal(value, first);
        }

        [Fact]
        public void AddFirst_AddItemToNonEmptyList_SecondPreviousEqualFirst()
        {
            var list = new DoublyLinkedList<int>(5);
            list.AddFirst(10);
            
            var secondNode = list.First.Next;
            
            Assert.Equal(list.First, secondNode.Previous);
        }
        
        [Fact]
        public void AddFirst_Add3Value_CountEqual3()
        {
            var list = new DoublyLinkedList<int>();
            
            list.AddFirst(5);
            list.AddFirst(10);
            list.AddFirst(15);
            
            Assert.Equal(3, list.Count);
        }
    }
}