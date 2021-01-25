using Xunit;

namespace CircularLinkedList.Tests
{
    public class Reverse
    {
        [Fact]
        public void Reverse_ReverseEmptyList_NewListIsEmpty()
        {
            var list = new CircularLinkedList<int>();
            var reversedList = list.Reverse();

            bool actual = reversedList.IsEmpty;

            Assert.True(actual);
        }
        
        [Fact]
        public void Reverse_ReverseNonEmptyList_ReturnReversedList()
        {
            int first = 1;
            int second = 2;
            int last = 3;
            var list = new CircularLinkedList<int>(first);
            list.AddLast(second);
            list.AddLast(last);
            var reversedList = list.Reverse();

            int firstFromReversedList = reversedList.First.Value;
            int secondFromReversedList = reversedList.First.Next.Value;
            int lastFromReversedList = reversedList.First.Next.Next.Value;
            
            Assert.Equal(last, firstFromReversedList);
            Assert.Equal(second, secondFromReversedList);
            Assert.Equal(first, lastFromReversedList);
        }
    }
}