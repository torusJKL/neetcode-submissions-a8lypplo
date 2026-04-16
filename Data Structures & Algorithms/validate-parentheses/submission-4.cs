public class Solution {
    public bool IsValid(string s) {
        if (s.Length % 2 != 0){
            return false;
        }

        var openBrackets = new Stack<char>();
        var closeToOpenBrackets = new Dictionary<char, char>(){
            { ')', '(' },
            { ']', '[' },
            { '}', '{' }
        };

        foreach (var val in s){

            // check if character is an opening bracket
            if (false == closeToOpenBrackets.ContainsKey(val)){
                openBrackets.Push(val);
                continue;
            }

            // no open brackets left to close
            if (openBrackets.Count() == 0){
                return false;
            }

            // check if the closing and opening brackets match
            if (openBrackets.Pop() == closeToOpenBrackets[val]){
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
