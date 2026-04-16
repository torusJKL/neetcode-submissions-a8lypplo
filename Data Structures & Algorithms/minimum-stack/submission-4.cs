public class MinStack {

    Stack<int> valStack;
    Stack<int> minStack;

    public MinStack() {
        valStack = new Stack<int>();
        minStack = new Stack<int>();
    }
    
    public void Push(int val) {
        int curMin = minStack.Count > 0 ? minStack.Peek() : val;

        if (curMin < val){
            minStack.Push(curMin);
        }
        else {
            minStack.Push(val);
        }

        valStack.Push(val);
    }
    
    public void Pop() {
        valStack.Pop();
        minStack.Pop();
    }
    
    public int Top() {
        return valStack.Peek();
    }
    
    public int GetMin() {
        return minStack.Peek();
    }
}
