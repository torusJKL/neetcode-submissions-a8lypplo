public class MinStack {

    Stack<int> valStack;
    Stack<int> minStack;

    public MinStack() {
        valStack = new Stack<int>();
        minStack = new Stack<int>();
    }
    
    public void Push(int val) {
        valStack.Push(val);
        
        if (minStack.Count == 0 || val <= minStack.Peek()){
            minStack.Push(val);
        }
    }
    
    public void Pop() {
        if(minStack.Peek() == valStack.Pop()){
            minStack.Pop();
        }
    }
    
    public int Top() {
        return valStack.Peek();
    }
    
    public int GetMin() {
        return minStack.Peek();
    }
}
