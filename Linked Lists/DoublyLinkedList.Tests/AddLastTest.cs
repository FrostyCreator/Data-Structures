using Xunit;

namespace DoublyLinkedList.Tests
{
    public class AddLastTest
    {
        [Fact]
        public void AddLast_AddValueToEmptyList_ThisValueIsFirstAndLast()
        {
            var list = new DoublyLinkedList<int>();
            int value = 10;
            
            list.AddLast(value);
            int first = list.First.Value;
            int last = list.Last.Value;
            
            Assert.Equal(value, first);
            Assert.Equal(value, last);
        }
        
        [Fact]
        public void AddLast_AddValueToNonEmptyList_LastEqualValue()
        {
            var list = new DoublyLinkedList<int>(5);
            int value = 10;
            
            list.AddLast(value);
            int last = list.Last.Value;
            
            Assert.Equal(value, last);
        }
        
        [Fact]
        public void AddLast_Add3Value_CountEqual3()
        {
            var list = new DoublyLinkedList<int>();
            
            list.AddLast(5);
            list.AddLast(10);
            list.AddLast(15);
            
            Assert.Equal(3, list.Count);
        }
    }
}