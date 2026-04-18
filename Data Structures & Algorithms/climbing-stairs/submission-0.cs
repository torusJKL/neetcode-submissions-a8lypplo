public class Solution {
    public int ClimbStairs(int n) {     
        //using recursion is not an effective way but is used here for the purpose of education

        if (n <= 1){
            return 1;
        }

        return ClimbStairs(n-1) + ClimbStairs(n-2);
    }
}
