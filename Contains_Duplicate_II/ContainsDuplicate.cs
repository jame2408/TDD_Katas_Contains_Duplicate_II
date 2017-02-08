using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Contains_Duplicate_II
{    
    [TestClass]
    public class ContainsDuplicate
    {
        [TestMethod]
        public void Test_k_is_zero_should_return_false()
        {
            var nums = new int[] { 1, 1 };
            var k = 0;

            var action = new Solution();

            Assert.IsFalse(action.ContainsNearbyDuplicate(nums, k));
        }
    }
}
