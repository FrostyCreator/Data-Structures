using Xunit;

namespace DoublyLinkedList.Tests
{
    public class Reverse
    {
        [Fact]
        public void Reverse_ReverseEmptyList_ReturnEmptyList()
        {
            var list = new DoublyLinkedList<int>();
            var newList = list.Reverse();

            bool actual = newList.IsEmpty;

            Assert.True(actual);
        }

        [Fact]
        public void Reverse_ReturnInvertedList()
        {
            int value1 = 0;
            int value2 = 5;
            int value3 = 10;
            var list = new DoublyLinkedList<int>();
            list.AddLast(value1);
            list.AddLast(value2);
            list.AddLast(value3);
            var actual = list.Reverse();

            var first = actual.First.Value;
            var second = actual.First.Next.Value;
            var last = actual.Last.Value;

            Assert.Equal(value3, first);
            Assert.Equal(value2, second);
            Assert.Equal(value1, last);
        }
    }
}