public class Solution {
    public int CalPoints(string[] operations) {
        var rec = new Stack<int>();

        for (int i = 0; i < operations.Length; ++i){
            string op = operations[i];

            switch (op) {
                case "+":
                    int prevTop = rec.Pop();
                    int sum = prevTop + rec.Peek();
                    rec.Push(prevTop);
                    rec.Push(sum);
                    break;
                case "C":
                    rec.Pop();
                    break;
                case "D":
                    int prod = rec.Peek() * 2;
                    rec.Push(prod);
                    break;
                default:
                    rec.Push(int.Parse(op));
                    break;
            }
        }

        int total = 0;
        while (rec.Count > 0){
            total += rec.Pop();
        }

        return total;
    }
}