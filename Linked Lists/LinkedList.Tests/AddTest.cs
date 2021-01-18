using LinkedList.Implementation;
using Xunit;

namespace LinkedList.Tests
{
    public class AddTest
    {
        [Theory]
        [InlineData(0)]
        [InlineData("0")]
        public void Add_Add1ElementToEmptyLinkedList_ThisElementIsFirst<T>(T value)
        {
            var linkedList = new LinkedList<T>();

            linkedList.Add(value);
            
            Assert.Equal(value, linkedList.First.Value);
        }
        
        [Theory]
        [InlineData(0)]
        [InlineData("0")]
        public void Add_Add1ElementToNonEmptyLinkedList_ThisElementIsSecond<T>(T value)
        {
            T firstValue = default;
            var linkedList = new LinkedList<T>(firstValue);

            linkedList.Add(value);
            
            Assert.NotNull(linkedList.First.Next);
            Assert.Equal(value, linkedList.First.Next.Value);
        }
        
        [Theory]
        [InlineData(10)]
        [InlineData("10")]
        public void Add_Add1ElementToEmptyLinkedList_CountEqual1<T>(T value)
        {
            var linkedList = new LinkedList<T>();

            linkedList.Add(value);
            
            Assert.Equal(1, linkedList.Count);
        }
        
        [Theory]
        [InlineData(10)]
        [InlineData("10")]
        public void Add_Add1ElementToNonEmptyLinkedList_CountEqual1<T>(T value)
        {
            T firstValue = default;
            var linkedList = new LinkedList<T>(firstValue);

            linkedList.Add(value);
            
            Assert.Equal(2, linkedList.Count);
        }
    }
}