public class MyStack {
    Queue<int> main;

    public MyStack() {
        main = new Queue<int>();
    }

    public void Push(int x) {
        main.Enqueue(x);
    }

    public int Pop() {
        for (int i = main.Count(); i > 1; --i) {
            main.Enqueue(main.Dequeue());
        }

        var topValue = main.Dequeue();

        return topValue;
    }

    public int Top() {
        for (int i = main.Count(); i > 1; --i) {
            main.Enqueue(main.Dequeue());
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