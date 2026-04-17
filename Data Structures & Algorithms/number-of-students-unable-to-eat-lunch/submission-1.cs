public class Solution {
    public int CountStudents(int[] students, int[] sandwiches) {
        int circStudents = 0;
        int squareStudents = 0;

        for (int i = 0; i < students.Length; ++i) {
            if (students[i] == 0) {
                ++circStudents;
            } else {
                ++squareStudents;
            }
        }

        for (int i = 0; i < sandwiches.Length; ++i) {
            if (sandwiches[i] == 0 && circStudents <= 0) {
                break;
            }

            if (sandwiches[i] == 1 && squareStudents <= 0) {
                break;
            }

            if (sandwiches[i] == 0) {
                --circStudents;
            } else {
                --squareStudents;
            }
        }

        return circStudents + squareStudents;
    }
}