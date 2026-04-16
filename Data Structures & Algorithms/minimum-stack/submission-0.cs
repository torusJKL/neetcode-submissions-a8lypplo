public class MinStack {

    Stack<int> valStack = null;
    Stack<int> minStack = null;

    public MinStack() {
        this.valStack = new Stack<int>();
        this.minStack = new Stack<int>();
    }
    
    public void Push(int val) {
        this.valStack.Push(val);
        
        if (this.minStack.Count == 0 || val <= this.minStack.Peek()){
            this.minStack.Push(val);
        }
    }
    
    public void Pop() {
        if(this.minStack.Peek() == this.valStack.Pop()){
            this.minStack.Pop();
        }
    }
    
    public int Top() {
        return this.valStack.Peek();
    }
    
    public int GetMin() {
        return this.minStack.Peek();
    }
}
