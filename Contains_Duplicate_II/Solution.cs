using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contains_Duplicate_II
{
    public static class Solution
    {
        public static bool ContainsNearbyDuplicate(int[] nums, int k)
        {
            if (k == 0)
            {
                return false;
            }

            var map = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (map.ContainsKey(nums[i]) && map.theSameNumberDistance(nums, i) <= k)
                {
                    return true;
                }
                map[nums[i]] = i;
            }
            return false;
        }

        private static int theSameNumberDistance(this Dictionary<int, int> map, int[] nums, int i)
        {
            return i - map[nums[i]];
        }
    }
}
