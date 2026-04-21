public class Solution {
    public int Search(int[] nums, int target) {
        var start = 0;
        var end = nums.Length - 1;

        return BinarySearch(nums, start, end, target);
    }

    public int BinarySearch(int[] nums, int start, int end, int target){
        if (end < start){
            return -1;
        }

        int middle = (start + end) / 2;

        if (nums[middle] == target){
            return middle;
        }

        if (nums[middle] > target){
            return BinarySearch(nums, start, middle - 1, target);
        }

        return BinarySearch(nums, middle + 1, end, target);
    }
}
