/**
 * Forward declaration of guess API.
 * @param  num   your guess
 * @return 	     -1 if num is higher than the picked number
 *			      1 if num is lower than the picked number
 *               otherwise return 0
 * int guess(int num);
 */

public class Solution : GuessGame {
    public int GuessNumber(int n) {
        var low = 1;
        var high = n;
        int middle;

        while (low <= high){
            // calculate middle overflow safe
            middle = (high - low) / 2 + low;
            var result = guess(middle);

            if (0 == result){
                return middle;
            }

            if (1 == result){
                low = middle + 1;
                continue;
            }

            high = middle - 1;
        }

        return -1;
    }
}