public class Solution {
    public int[] ReplaceElements(int[] arr) {

        int rightMax = -1;
        int[] result = new int[arr.Length];

        for (int i = arr.Length - 1; i >= 0; i--){
            result[i] = rightMax;
            rightMax = Math.Max(arr[i], rightMax);
        }

        return result;
    }
}