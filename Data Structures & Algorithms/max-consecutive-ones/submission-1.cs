public class Solution {
    public int FindMaxConsecutiveOnes(int[] nums) {
        var counter = 0;
        var max = 0;

        for (int i = 0; i < nums.Length; ++i){
            if (nums[i] == 0){
                counter = 0;
                continue;
            }

            ++counter;
            if (max < counter){
                max = counter;
            }
        }

        return max;
    }
}