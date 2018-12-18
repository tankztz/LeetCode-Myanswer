using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoTester
{
    class S1_Array6
    {
        public static bool IncreasingTriplet(int[] nums)
        {
            //int[] beforeMin = nums;
            bool[] ans = new bool[nums.Length + 1];
            int min = int.MaxValue;
            int minReach2 = int.MaxValue;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] > minReach2) return true;
                if (nums[i] < min) min = nums[i];
                if (nums[i] > min)
                {
                    if (minReach2 > nums[i]) minReach2 = nums[i];
                }
            }
            return false;
        }
    }
}
