public class Solution {
    public int RemoveElement(int[] nums, int val) {
        var count = 0;
        var writePointer = 0;
        var readFromEndPointer = nums.Length - 1;

        for (var i = 0; i < nums.Length; ++i){
            if (nums[i] != val){
                ++writePointer;
                ++count;
                continue;
            }

            while (readFromEndPointer > i && readFromEndPointer > 0){
                if (nums[readFromEndPointer] == val){
                    --readFromEndPointer;
                    continue;
                }

                nums[i] = nums[readFromEndPointer];
                --readFromEndPointer;
                break;
            }
        }

        return count;
    }
}