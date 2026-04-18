public class MyStack {
    Queue<int> main;

    public MyStack() {
        main = new Queue<int>();
    }

    public void Push(int x) {
        main.Enqueue(x);
    }

    public int Pop() {
        var valuesToMove = main.Count();

        while (valuesToMove > 1) {
            main.Enqueue(main.Dequeue());
            --valuesToMove;
        }

        var topValue = main.Dequeue();

        return topValue;
    }

    public int Top() {
        var valuesToMove = main.Count();

        while (valuesToMove > 1){
            main.Enqueue(main.Dequeue());
            --valuesToMove;
        }

        var topValue = main.Dequeue();
        main.Enqueue(topValue);

        return topValue;
    }

    public bool Empty() {
        return main.Count() <= 0;
    }
}

/**
 * Your MyStack object will be instantiated and called as such:
 * MyStack obj = new MyStack();
 * obj.Push(x);
 * int param_2 = obj.Pop();
 * int param_3 = obj.Top();
 * bool param_4 = obj.Empty();
 */