using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace mergesort
{
    public class Tests
    {
        [Fact]
        public void ListSorted()
        {
            var unsorted = new List<int> { 3, 12, 5, 1, 7, };
            var expected = new List<int> { 1, 3, 5, 7, 12 };
            var actual = unsorted.MergeSort();
            Assert.True(actual.SequenceEqual(expected));
        }
    }
}
