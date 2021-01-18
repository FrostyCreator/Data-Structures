using System;
using LinkedList.Implementation;
using Xunit;

namespace LinkedList.Tests
{
    public class ReverseTest
    {
        [Fact]
        public void Reverse_EmptyList_ReturnError()
        {
            var list = new LinkedList<int>();
            
            Assert.Throws<InvalidOperationException>(() => list.Reverse());
        }
        
        [Fact]
        public void Reverse_List_ReturnInvertedList()
        {
            var list = new LinkedList<int>(0);
            list.Add(1);
            
            list.Reverse();
            
            Assert.Equal(1, list.First.Value);
            Assert.Equal(0, list.First.Next.Value);
        }
    }
}