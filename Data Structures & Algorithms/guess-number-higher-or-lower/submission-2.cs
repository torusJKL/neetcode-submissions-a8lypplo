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
        return GuessCorrectNumber(1, n);
    }

    private int GuessCorrectNumber(int low, int high) {
        var middle = low + (high - low) / 2;
        var guessResponse = guess(middle);

        if (guessResponse == 0) {
            return middle;
        }

        if (guessResponse == 1) {
            return GuessCorrectNumber(middle + 1, high);
        }

        return GuessCorrectNumber(low, middle - 1);
    }
}