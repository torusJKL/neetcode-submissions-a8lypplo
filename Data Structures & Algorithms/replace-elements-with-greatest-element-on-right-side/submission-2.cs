public class Solution {
    public int[] ReplaceElements(int[] arr) {
        int rightMax = -1;

        for (int i = arr.Length - 1; i >= 0; i--){
            int current = arr[i];
            arr[i] = rightMax;
            rightMax = Math.Max(current, rightMax);
        }

        return arr;
    }
}