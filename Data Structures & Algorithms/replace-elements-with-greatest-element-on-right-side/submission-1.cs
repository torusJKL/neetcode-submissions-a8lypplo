public class Solution {
    public int[] ReplaceElements(int[] arr) {
        for (int i = 0; i < arr.Length - 1; i++){
            
            int largestNum = 0;
            for (int j = i + 1; j < arr.Length; j++){
                if (arr[j] > largestNum){
                    largestNum = arr[j];
                }
            }

            arr[i] = largestNum;
        }

        arr[arr.Length - 1] = -1;

        return arr;
    }
}