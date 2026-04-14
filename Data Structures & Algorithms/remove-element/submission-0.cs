public class Solution {
    public int RemoveElement(int[] nums, int val) {
        var count = 0;
        var writePointer = 0;

        for (var i = 0; i < nums.Length; ++i){
            if (nums[i] == val){
                continue;
            }

            nums[writePointer] = nums[i];
            ++writePointer;
            ++count;
        }

        return count;
    }
}