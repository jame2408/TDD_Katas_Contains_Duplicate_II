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

            Assert.IsFalse(Solution.ContainsNearbyDuplicate(nums, k));
        }

        [TestMethod]
        public void Test_nums_1_1_and_k_is_1_should_return_true()
        {
            var nums = new int[] { 1, 1 };
            var k = 1;

            Assert.IsTrue(Solution.ContainsNearbyDuplicate(nums, k));
        }

        [TestMethod]
        public void Test_nums_1_2_and_k_is_1_should_return_false()
        {
            var nums = new int[] { 1, 2 };
            var k = 1;

            Assert.IsFalse(Solution.ContainsNearbyDuplicate(nums, k));
        }

        [TestMethod]
        public void Test_nums_1_2_1_and_k_is_1_should_return_false()
        {
            var nums = new int[] { 1, 2, 1 };
            var k = 1;

            Assert.IsFalse(Solution.ContainsNearbyDuplicate(nums, k));
        }
    }
}
