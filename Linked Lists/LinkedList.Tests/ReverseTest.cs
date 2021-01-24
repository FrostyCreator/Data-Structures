using System;
using System.Runtime.CompilerServices;
using LinkedList.Implementation;
using Xunit;

namespace LinkedList.Tests
{
    public class ReverseTest
    {
        [Fact]
        public void Reverse_EmptyList_ReturnEmptyList()
        {
            var list = new LinkedList<int>();
            var reversedList = list.Reverse();
            
            bool actual = reversedList.IsEmpty;
            
            Assert.True(actual);
        }
        
        [Fact]
        public void Reverse_List_ReturnInvertedList()
        {
            var list = new LinkedList<int>(0);
            list.Add(1);
            list.Add(2);
            var reversedList = list.Reverse();

            int firstValue = reversedList.First.Value;
            int secondValue = reversedList.First.Next.Value;
            int lastValue = reversedList.First.Next.Next.Value;
            
            Assert.Equal(2, firstValue);
            Assert.Equal(1, secondValue);
            Assert.Equal(0, lastValue);
        }
    }
}