public class Solution {
    public bool IsValid(string s) {
        if (s.Length % 2 != 0){
            return false;
        }

        var openBrackets = new Stack<char>();

        foreach (var val in s){
            if (val == '(' || val == '[' || val == '{'){
                openBrackets.Push(val);
                continue;
            }

            // no open brackets left to close
            if (openBrackets.Count() == 0 && (val == ')' || val == ']' || val == '}')){
                return false;
            }

            if (val == ')' && openBrackets.Pop() == '('){
                continue;
            }

            if (val == ']' && openBrackets.Pop() == '['){
                continue;
            }

            if (val == '}' && openBrackets.Pop() == '{'){
                continue;
            }

            return false;
        }

        // open brackets where not closed
        if (openBrackets.Count() > 0){
            return false;
        }

        return true;
    }
}
