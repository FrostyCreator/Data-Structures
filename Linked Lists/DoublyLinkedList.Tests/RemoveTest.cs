using Xunit;

namespace DoublyLinkedList.Tests
{
    public class RemoveTest
    {
        [Fact]
        public void Remove_RemoveFromEmptyList_ReturnFalse()
        {
            var list = new DoublyLinkedList<int>();

            bool actual = list.Remove(0);
            
            Assert.False(actual);
        }

        [Fact]
        public void Remove_RemoveOnlyOneItem_ReturnTrue()
        {
            var list = new DoublyLinkedList<int>(5);

            var actual = list.Remove(5);

            Assert.True(actual);
        }

        [Fact]
        public void Remove_RemoveFirstItem_ReturnTrue()
        {
            var list = new DoublyLinkedList<int>(5);
            list.AddLast(10);
            list.AddLast(15);

            var actual = list.Remove(5);

            Assert.True(actual);
        }

        [Fact]
        public void Remove_RemoveSecondItem_ReturnTrue()
        {
            var list = new DoublyLinkedList<int>(5);
            list.AddLast(10);
            list.AddLast(15);

            var actual = list.Remove(10);
            var first = list.First;
            var last = list.Last;

            Assert.True(actual);
            Assert.Equal(list.First.Next, last);
            Assert.Equal(list.Last.Previous, first);
        }

        [Fact]
        public void Remove_RemoveLastItem_ReturnTrue()
        {
            var list = new DoublyLinkedList<int>(5);
            list.AddLast(10);
            list.AddLast(15);

            var actual = list.Remove(15);
            var last = list.Last;

            Assert.True(actual);
            Assert.Equal(list.First.Next, last);
        }

        [Fact]
        public void Remove_RemoveItemThatIsNotInList_ReturnFalse()
        {
            var list = new DoublyLinkedList<int>(5);
            list.AddLast(10);
            list.AddLast(15);

            var actual = list.Remove(20);

            Assert.False(actual);
        }
    }
}