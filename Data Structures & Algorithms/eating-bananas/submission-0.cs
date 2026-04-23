public class Solution {
    public int MinEatingSpeed(int[] piles, int h) {
        int low = 1;
        int high = 1000000000;
        int middle;
        int bestEatingRate = high;

        while (low <= high){
            middle = low + (high - low) / 2;

            int hoursSpent = 0;
            for (int i = 0; i < piles.Length; ++i){
                hoursSpent += (int)(Math.Ceiling(piles[i] / (double)middle));
            }

            if (hoursSpent > h){
                low = middle + 1;
                continue;
            }

            bestEatingRate = middle;
            high = middle - 1;
        }

        return bestEatingRate;
    }
}
