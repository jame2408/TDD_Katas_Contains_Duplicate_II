using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contains_Duplicate_II
{
    public class Solution
    {
        public bool ContainsNearbyDuplicate(int[] nums, int k)
        {
            if (k == 0)
            {
                return false;
            }

            var map = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (map.ContainsKey(nums[i]) && i - map[nums[i]] <= k)
                {
                    return true;
                }
                map[nums[i]] = i;
            }
            return false;
        }
    }
}
