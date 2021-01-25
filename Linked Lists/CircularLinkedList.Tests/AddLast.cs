using System;
using Xunit;

namespace CircularLinkedList.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void AddLast_AddToEmptyList_CountEqual1()
        {
            var list = new CircularLinkedList<int>();
            list.AddLast(5);

            int actual = list.Count;
            
            Assert.Equal(1, actual);
        }
        
        [Fact]
        public void AddLast_AddToEmptyList_NewItemIsHeadAndNext()
        {
            var list = new CircularLinkedList<int>();
            list.AddLast(5);

            var actualFirst = list.First;
            var actualSecond = list.First.Next;
            
            Assert.Equal(actualFirst, actualSecond);
        }
        
        [Fact]
        public void AddLast_Add3Item_NextForLastIsFirst()
        {
            var list = new CircularLinkedList<int>(5);
            list.AddLast(10);
            list.AddLast(15);

            var actualFirst = list.First;
            var actualLast = list.First.Next.Next;
            
            Assert.Equal(actualFirst, actualLast.Next);
        }

        [Fact] public void AddLast_Add3Item_CountEqual3()
        {
            var list = new CircularLinkedList<int>(5);
            list.AddLast(10);
            list.AddLast(15);

            int actualCount = list.Count;
            
            Assert.Equal(3, actualCount);
        }
    }
}