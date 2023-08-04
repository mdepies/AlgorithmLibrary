using Xunit;
using CsAlgorithmLibrary;

namespace SortAlgorithmTests
{
    public class SortCategoryTests
    {
        [Fact]
        public void TestInsertionSortWithShortArray()
        {
            int[] itemArray = new int[] { 5, 9, 1, 2, 4, 7 };
            SortCategory.InsertionSort(itemArray);
            Assert.True(IsSortedAscendingOrder(itemArray));
        }
        [Fact]
        public void TestInsertionSortWithNullArray()
        {
            int[]? itemArray = null;
            #pragma warning disable CS8604
            SortCategory.InsertionSort(itemArray);
            #pragma warning restore CS8604
            Assert.Null(itemArray);
        }
        [Fact]
        public void TestInsertionSortWithEmptyArray()
        {
            int[] itemArray = new int[0];
            SortCategory.InsertionSort(itemArray);
            Assert.Empty(itemArray);
        }
        [Fact]
        public void TestInsertionSortWithOneItem()
        {
            int testValue = 5;
            int[] itemArray = new int[] { testValue };
            SortCategory.InsertionSort(itemArray);
            Assert.Single<int>(itemArray);
            Assert.Equal(testValue, itemArray[0]);
        }
        [Fact]
        public void TestInsertionSortWithDuplicates()
        {
            int[] itemArray = new int[] { 2, 4, 2, 8, 5, 1, 9, 7, 9, 1, 3, 6, 7, 11, 2 };
            SortCategory.InsertionSort(itemArray);
            Assert.True(IsSortedAscendingOrder(itemArray));
        }
        [Fact]
        public void TestInsertionSortWithOrderedArray()
        {
            int[] itemArray = new int[] { 1, 2, 3, 4, 5, 10, 11 };
            SortCategory.InsertionSort(itemArray);
            Assert.True(IsSortedAscendingOrder(itemArray));
        }
        private static bool IsSortedAscendingOrder(int [] sortedArray)
        {
            for (int i = 1; i < sortedArray.Length; i++)
            {
                if (sortedArray[i - 1] > sortedArray[i])
                {
                    Assert.Fail($"{i - 1}:{sortedArray[i-1]} > {i}:{sortedArray[i]}");
                    return false;
                }
            }
            return true;
        }
    }
}