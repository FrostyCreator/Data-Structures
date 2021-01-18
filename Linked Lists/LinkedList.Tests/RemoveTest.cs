using LinkedList.Implementation;
using Xunit;

namespace LinkedList.Tests
{
    public class RemoveTest
    {
        [Fact]
        public void Remove_RemoveFromEmptyList_ReturnFalse()
        {
            var linkedList = new LinkedList<int>();

            bool actual = linkedList.Remove(0);
            
            Assert.False(actual);
        }
        
        [Fact]
        public void Remove_ItemNotIncludedInList_ReturnFalse()
        {
            var linkedList = new LinkedList<int>(0);
            linkedList.Add(1);
            linkedList.Add(2);

            bool actual = linkedList.Remove(3);
            
            Assert.False(actual);
        }
        
        [Fact]
        public void Remove_RemoveFirstItem_ReturnTrue()
        {
            var linkedList = new LinkedList<int>(0);
            linkedList.Add(1);
            linkedList.Add(2);

            bool actual = linkedList.Remove(0);
            
            Assert.True(actual);
            Assert.Equal(2, linkedList.Count);
        }
        
        [Fact]
        public void Remove_RemoveLastItem_ReturnTrue()
        {
            var linkedList = new LinkedList<int>(0);
            linkedList.Add(1);
            linkedList.Add(2);
            linkedList.Add(3);

            bool actual = linkedList.Remove(3);
            
            Assert.True(actual);
            Assert.Equal(3, linkedList.Count);
        }
    }
}