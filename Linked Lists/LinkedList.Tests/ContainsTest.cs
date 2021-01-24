using LinkedList.Implementation;
using Xunit;

namespace LinkedList.Tests
{
    public class ContainsTest
    {
        [Fact]
        public void Contains_FirstValueContainedInList_ReturnTrue()
        {
            var linkedList = new LinkedList<int>(0);
            linkedList.Add(1);
            linkedList.Add(2);
            linkedList.Add(3);

            bool actual = linkedList.Contains(0);
            
            Assert.True(actual);
        }
        
        [Fact]
        public void Contains_LastValueContainedInList_ReturnTrue()
        {
            var linkedList = new LinkedList<int>(0);
            linkedList.Add(1);
            linkedList.Add(2);
            linkedList.Add(3);

            bool actual = linkedList.Contains(3);
            
            Assert.True(actual);
        }
        
        [Fact]
        public void Contains_ValueNotContainedInList_ReturnFalse()
        {
            var linkedList = new LinkedList<int>(0);
            linkedList.Add(1);
            linkedList.Add(2);
            linkedList.Add(3);

            bool actual = linkedList.Contains(5);
            
            Assert.False(actual);
        }
        
        [Fact]
        public void Contains_EmptyList_ReturnFalse()
        {
            var linkedList = new LinkedList<int>();

            bool actual = linkedList.Contains(5);
            
            Assert.False(actual);
        }
    }
}