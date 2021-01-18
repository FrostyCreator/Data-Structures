using LinkedList.Implementation;
using Xunit;

namespace LinkedList.Tests
{
    public class FindTest
    {
        [Fact]
        public void Find_ValueContainedInList_ReturnValue()
        {
            Find_ValueContainedInList_ReturnValue_Helper<int>(0, 1, 2, 0);
            Find_ValueContainedInList_ReturnValue_Helper<string>("0", "1", "2", "0");
        }
        
        [Fact]
        public void Find_ValueNotContainedInList_ReturnNull()
        {
            Find_ValueNotContainedInList_ReturnNull_Helper<int>(0, 1, 2, 3);
            Find_ValueNotContainedInList_ReturnNull_Helper<string>("0", "1", "2", "3");
        }
        
        public void Find_ValueContainedInList_ReturnValue_Helper<T>(T value, params T[] tempList)
        {
            var linkedList = new LinkedList<T>();
            foreach (T item in tempList)
            {
                linkedList.Add(item);
            }

            var actual = linkedList.Find(value);
            
            Assert.Equal(value, actual.Value);
        }

        public void Find_ValueNotContainedInList_ReturnNull_Helper<T>(T value, params T[] tempList)
        {
            var linkedList = new LinkedList<T>();
            foreach (T item in tempList)
            {
                linkedList.Add(item);
            }

            var actual = linkedList.Find(value);
            
            Assert.Null(actual);
        }
    }
}