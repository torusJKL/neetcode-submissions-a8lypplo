public class Solution {
    public int FindMaxConsecutiveOnes(int[] nums) {
        var counter = 0;
        var max = 0;

        foreach (var num in nums){
            if (num == 0){
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