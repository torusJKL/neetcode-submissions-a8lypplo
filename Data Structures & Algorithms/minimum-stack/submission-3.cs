public class MinStack {

    Stack<int> valStack;
    Stack<int> minStack;

    public MinStack() {
        valStack = new Stack<int>();
        minStack = new Stack<int>();
    }
    
    public void Push(int val) {
        if (valStack.Count > 0 && minStack.Peek() < val){
            minStack.Push(minStack.Peek());
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
