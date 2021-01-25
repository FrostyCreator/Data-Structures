using Xunit;

namespace CircularLinkedList.Tests
{
    public class AddFirst
    {
        [Fact]
        public void AddFirst_AddToEmptyList_CountEqual1()
        {
            var list = new CircularLinkedList<int>();
            list.AddFirst(5);

            int actual = list.Count;
            
            Assert.Equal(1, actual);
        }
        
        [Fact]
        public void AddFirst_AddToEmptyList_NewItemIsHeadAndNext()
        {
            var list = new CircularLinkedList<int>();
            list.AddFirst(5);

            var actualFirst = list.First;
            var actualSecond = list.First.Next;
            
            Assert.Equal(actualFirst, actualSecond);
        }
        
        [Fact]
        public void AddFirst_Add3Item_extForLastIsFirst()
        {
            var list = new CircularLinkedList<int>(5);
            list.AddFirst(10);
            list.AddFirst(15);

            var actualFirst = list.First;
            var actualLast = list.First.Next.Next;
            
            Assert.Equal(actualFirst, actualLast.Next);
        }

        [Fact] public void AddFirst_Add3Item_CountEqual3()
        {
            var list = new CircularLinkedList<int>(5);
            list.AddFirst(10);
            list.AddFirst(15);

            int actualCount = list.Count;
            
            Assert.Equal(3, actualCount);
        }
    }
}