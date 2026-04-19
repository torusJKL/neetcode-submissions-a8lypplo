public class Solution {
    public void SortColors(int[] nums) {
        // using Bucket sort - O(n)

        var buckets = new int[]{0,0,0};

        for (int i = 0; i < nums.Length; ++i){
            // the index coresponds to the value in nums
            ++buckets[nums[i]];
        }

        var index = 0;

        // since the iterations are limited to n times it is still O(n)
        for (int i = 0; i < buckets.Length; ++i){
            for (int j = 0; j < buckets[i]; ++j){
                nums[index] = i;
                ++index;
            }
        }
    }
}