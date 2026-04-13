public class Solution {
    public int FindMaxConsecutiveOnes(int[] nums) {
        var counter = 0;
        var max = 0;

        for (int i = 0; i < nums.Length; ++i){
            if (nums[i] == 0){
                counter = 0;

                // only contiue if there is a possibility to get a higher max value
                if (nums.Length - i - 1 > max){
                    continue;
                }

                break;
            }

            ++counter;
            if (max < counter){
                max = counter;
            }
        }

        return max;
    }
}