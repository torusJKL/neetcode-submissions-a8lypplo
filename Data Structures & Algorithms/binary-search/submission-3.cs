public class Solution {
    public int Search(int[] nums, int target) {
        var start = 0;
        var end = nums.Length - 1;

        while (start <= end) {
            var middle = (start + end) / 2;

            if (nums[middle] < target) {
                start = middle + 1;
            } else if (nums[middle] > target) {
                end = middle - 1;
            } else {
                return middle;
            }
        }

        return -1;
    }
}
